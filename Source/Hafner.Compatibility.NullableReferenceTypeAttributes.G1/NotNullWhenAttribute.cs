namespace System.Diagnostics.CodeAnalysis;

using System;

/// <summary>The conditional postcondition attribute <see cref="NotNullWhenAttribute"/> specifies that when a method returns <see cref="ReturnValue"/>, the parameter will not be null even if the corresponding type allows it.</summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
public sealed class NotNullWhenAttribute : Attribute {

    /// <summary>Initializes the attribute with the specified return value condition.</summary>
    /// <param name="returnValue">The return value condition. If the method returns this value, the associated parameter will not be <see langword="null"/>.</param>
    public NotNullWhenAttribute(bool returnValue) {
        ReturnValue = returnValue;
    }

    /// <summary>Gets the return value condition.</summary>
    public bool ReturnValue { get; }

}
