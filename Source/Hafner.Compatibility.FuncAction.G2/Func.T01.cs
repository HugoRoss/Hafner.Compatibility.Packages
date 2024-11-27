namespace System;

/// <summary>Encapsulates a method that has 1 parameter and that returns a value of type <typeparamref name="TResult"/>.</summary>
/// <typeparam name="T1">The type of parameter 1 of the function this delegate encapsulates.</typeparam>
/// <typeparam name="TResult">The type of the result of the function this delegate encapsulates.</typeparam>
/// <param name="arg1">Parameter 1 of the method that this delegate encapsulates.</param>
public delegate TResult Func<in T1, out TResult>(T1 arg1);
