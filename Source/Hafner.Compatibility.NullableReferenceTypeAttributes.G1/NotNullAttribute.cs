namespace System.Diagnostics.CodeAnalysis;

using System;

/// <summary>
/// The postcondition attribute <see cref="NotNullAttribute"/> specifies that an output is not null even if the corresponding type allows it or that a nullable input argument is not <see langword="null"/> when the call returns.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
public sealed class NotNullAttribute : Attribute {

    /// <summary>
    /// Initializes a new instance of the <see cref="NotNullAttribute"/> class.
    /// </summary>
    public NotNullAttribute() {
    }

}
