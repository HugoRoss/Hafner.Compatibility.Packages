namespace System {

    /// <summary>Encapsulates a method that has 2 parameters and does not return a value.</summary>
    /// <typeparam name="T1">The type of parameter 1 of the method this delegate encapsulates.</typeparam>
    /// <typeparam name="T2">The type of parameter 2 of the method this delegate encapsulates.</typeparam>
    /// <param name="arg1">Parameter 1 of the method that this delegate encapsulates.</param>
    /// <param name="arg2">Parameter 2 of the method that this delegate encapsulates.</param>
    public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);

}
