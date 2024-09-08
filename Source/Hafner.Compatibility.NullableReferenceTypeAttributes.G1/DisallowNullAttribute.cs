namespace System.Diagnostics.CodeAnalysis;

using System;

/// <summary>
/// The precondition attribute <see cref="DisallowNullAttribute"/> specifies that <see langword="null"/> is disallowed as an input even if the corresponding type allows it.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
public sealed class DisallowNullAttribute : Attribute {

    /// <summary>
    /// Initializes a new instance of the <see cref="DisallowNullAttribute"/> class.
    /// </summary>
    public DisallowNullAttribute() {
    }

}
