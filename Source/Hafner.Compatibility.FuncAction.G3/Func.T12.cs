namespace System {

    /// <summary>Encapsulates a method that has 12 parameters and that returns a value of type <typeparamref name="TResult"/>.</summary>
    /// <typeparam name="T1">The type of parameter 1 of the function this delegate encapsulates.</typeparam>
    /// <typeparam name="T2">The type of parameter 2 of the function this delegate encapsulates.</typeparam>
    /// <typeparam name="T3">The type of parameter 3 of the function this delegate encapsulates.</typeparam>
    /// <typeparam name="T4">The type of parameter 4 of the function this delegate encapsulates.</typeparam>
    /// <typeparam name="T5">The type of parameter 5 of the function this delegate encapsulates.</typeparam>
    /// <typeparam name="T6">The type of parameter 6 of the function this delegate encapsulates.</typeparam>
    /// <typeparam name="T7">The type of parameter 7 of the function this delegate encapsulates.</typeparam>
    /// <typeparam name="T8">The type of parameter 8 of the function this delegate encapsulates.</typeparam>
    /// <typeparam name="T9">The type of parameter 9 of the function this delegate encapsulates.</typeparam>
    /// <typeparam name="T10">The type of parameter 10 of the function this delegate encapsulates.</typeparam>
    /// <typeparam name="T11">The type of parameter 11 of the function this delegate encapsulates.</typeparam>
    /// <typeparam name="T12">The type of parameter 12 of the function this delegate encapsulates.</typeparam>
    /// <typeparam name="TResult">The type of the result of the function this delegate encapsulates.</typeparam>
    /// <param name="arg1">Parameter 1 of the method that this delegate encapsulates.</param>
    /// <param name="arg2">Parameter 2 of the method that this delegate encapsulates.</param>
    /// <param name="arg3">Parameter 3 of the method that this delegate encapsulates.</param>
    /// <param name="arg4">Parameter 4 of the method that this delegate encapsulates.</param>
    /// <param name="arg5">Parameter 5 of the method that this delegate encapsulates.</param>
    /// <param name="arg6">Parameter 6 of the method that this delegate encapsulates.</param>
    /// <param name="arg7">Parameter 7 of the method that this delegate encapsulates.</param>
    /// <param name="arg8">Parameter 8 of the method that this delegate encapsulates.</param>
    /// <param name="arg9">Parameter 9 of the method that this delegate encapsulates.</param>
    /// <param name="arg10">Parameter 10 of the method that this delegate encapsulates.</param>
    /// <param name="arg11">Parameter 11 of the method that this delegate encapsulates.</param>
    /// <param name="arg12">Parameter 12 of the method that this delegate encapsulates.</param>
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

}
