# Moqunity

Moqunity is a wrapper for Unity3d Scripting API.

It helps to increase scripts testability.

It allows to substitute (other words to mock) some code parts in testing context.

# Context

## Introduction
Context is a class that provides access to particular wrappers such as Time, SystemInfo, Application etc.

Context may be inherited and overridden for a block of code.
``` CSharp
//Regular context: Moqunity.Context.Factory.Time behaves the same as UnityEngine.Time
float timeScale = Context.Factory.Time.scale;

//Overridden context: Moqunity.Context.Factory.Time behaves the way you want it to.
//Overridden context is valid inside of a block even if it used implicitly.
using(var context = new TestingContext<MyFactory>())
{
  Context.Factory.Init();
  timeScale = Context.Factory.Time.scale;
}
```

## Unit-test example

Class for testing. Please, don't judge it. This is just an example to help you to get the idea.
``` CSharp
using Time = Moqunity.Abstract.UnityEngine.Time;//comment this line to get rid of Moqunity
using UnityEngine;
using System;

public class SimpleTimer : MonoBehaviour
{
    private float fireTime = 0.0f;
    private bool isActive = false;
    private Action fireCallback = null;

    private Time Time { get; } = Moqunity.Context.Factory.Time;//comment this line to get rid of Moqunity

    public void Set(float time, Action callback)
    {
        if (isActive) return;
        fireTime = Time.realtimeSinceStartup + time;
        fireCallback = callback;
        isActive = true;
    }

    private void Update()
    {
        if (!isActive) return;
        if (Time.realtimeSinceStartup >= fireTime)
        {
            fireCallback?.Invoke();
            isActive = false;
        }
    }
}
```

Unit-tests class

`MyTime` is a class that provides a way to substitute `Time.realtimeSinceStartup` value.

`MyFactory` is a class that privide access to a MyTime instance.

`CheckCallbackWasFiredInTime()` is a method that tests if the timer fires in time.

`CheckCallbackWasNotFiredBeforeTime()` is a method that tests if the timer remains not firing before it's time.

``` CSharp
using System.Collections;
using UnityEngine.TestTools;
using Moqunity;
using UnityEngine;
using Moqunity.Fake.UnityEngine;
using NUnit.Framework;
using Time = Moqunity.Abstract.UnityEngine.Time;

public class SimpleTimerTests
{
    private GameObject gameObject;

    private class MyTyme : FakeTime
    {
        public float overriddenRealtime;

        public override float realtimeSinceStartup => overriddenRealtime;

        public void SetRealtimeSinceStartup(float value) => overriddenRealtime = value;
    }

    private class MyFactory : TestingFactory
    {
        private readonly Time overriddenTime;

        public MyFactory(Time time) => overriddenTime = time;

        protected override Time CreateTime() => overriddenTime;
    }

    [UnitySetUp]
    public IEnumerator Setup()
    {
        gameObject = new GameObject();
        yield return null;
    }

    [UnityTest]
    public IEnumerator CheckCallbackWasFiredInTime()
    {
        var time = new MyTyme();
        var factory = new MyFactory(time);
        factory.Init();
        using var context = new TestingContext(factory);
        {
            bool wasFired = false;
            var timer = gameObject.AddComponent<SimpleTimer>();
            yield return null;
            timer.Set(10.0f, () => wasFired = true);
            yield return null;
            time.SetRealtimeSinceStartup(10.0f);
            yield return null;
            Assert.IsTrue(wasFired);
            Object.Destroy(timer);
        }
    }

    [UnityTest]
    public IEnumerator CheckCallbackWasNotFiredBeforeTime()
    {
        var time = new MyTyme();
        var factory = new MyFactory(time);
        factory.Init();
        using var context = new TestingContext(factory);
        {
            bool wasFired = false;
            var timer = gameObject.AddComponent<SimpleTimer>();
            yield return null;
            timer.Set(10.0f, () => wasFired = true);
            yield return null;
            time.SetRealtimeSinceStartup(9.99f);
            yield return null;
            Assert.IsFalse(wasFired);
            Object.Destroy(timer);
        }
    }

    [UnityTearDown]
    public IEnumerator TearDown()
    {
        Object.Destroy(gameObject);
        yield return null;
    }
}
```

# Structure
The package is consist of several logical parts

* Abstract - interfaces that are copies of Unity API equivalents
* Default - default implementations of interfaces. All of them simply redirect calls to Unity API
* Fake - implementations of interfaces that are fully virtual and can be used as a base for your context
