namespace System {

    /// <summary>Encapsulates a method that has no parameters and that returns a value of type <typeparamref name="TResult"/>.</summary>
    /// <typeparam name="TResult">The type of the result of the function this delegate encapsulates.</typeparam>
    public delegate TResult Func<out TResult>();

}
