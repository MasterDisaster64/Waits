**Waits** adds a couple of helpers that make it easy to reuse `Wait` objects throughout your Unity code. This saves garbage collection when using coroutines, speeding up your game.

|Standard Unity code|Waits replacement|
| ------------ | ------------ |
|`new WaitForFixedUpdate()`|`Waits.fixedUpdate`|
|`new WaitForEndOfFrame()`|`Waits.endOfFrame`|
|`new WaitForSeconds(time)`|`Waits.Seconds(time)`|
|`new WaitForSecondsRealtime(time)`|`Waits.SecondsRealtime(time)`|

It's not recommened to use this for creating lots of `WaitForSeconds` or `WaitForSecondsRealtime` objects with random values. That would clog up memory with objects you're likely not reusing.
