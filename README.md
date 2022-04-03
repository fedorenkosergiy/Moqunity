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
