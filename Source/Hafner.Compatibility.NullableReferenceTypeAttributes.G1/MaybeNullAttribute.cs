namespace System.Diagnostics.CodeAnalysis;

using System;

/// <summary>
/// The postcondition attribute <see cref="MaybeNullAttribute"/> specifies that an output may be <see langword="null"/> even if the corresponding type disallows it.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
public sealed class MaybeNullAttribute : Attribute {

    /// <summary>
    /// Initializes a new instance of the <see cref="MaybeNullAttribute"/> class.
    /// </summary>
    public MaybeNullAttribute() {
    }

}
