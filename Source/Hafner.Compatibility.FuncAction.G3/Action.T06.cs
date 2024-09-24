namespace System {

    /// <summary>Encapsulates a method that has 6 parameters and does not return a value.</summary>
    /// <typeparam name="T1">The type of parameter 1 of the method this delegate encapsulates.</typeparam>
    /// <typeparam name="T2">The type of parameter 2 of the method this delegate encapsulates.</typeparam>
    /// <typeparam name="T3">The type of parameter 3 of the method this delegate encapsulates.</typeparam>
    /// <typeparam name="T4">The type of parameter 4 of the method this delegate encapsulates.</typeparam>
    /// <typeparam name="T5">The type of parameter 5 of the method this delegate encapsulates.</typeparam>
    /// <typeparam name="T6">The type of parameter 6 of the method this delegate encapsulates.</typeparam>
    /// <param name="arg1">Parameter 1 of the method that this delegate encapsulates.</param>
    /// <param name="arg2">Parameter 2 of the method that this delegate encapsulates.</param>
    /// <param name="arg3">Parameter 3 of the method that this delegate encapsulates.</param>
    /// <param name="arg4">Parameter 4 of the method that this delegate encapsulates.</param>
    /// <param name="arg5">Parameter 5 of the method that this delegate encapsulates.</param>
    /// <param name="arg6">Parameter 6 of the method that this delegate encapsulates.</param>
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

}
