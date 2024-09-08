namespace System.Diagnostics.CodeAnalysis;

using System;

/// <summary>
/// The precondition attribute <see cref="AllowNullAttribute"/> specifies that <see langword="null"/> is allowed as an input even if the corresponding type disallows it.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
public sealed class AllowNullAttribute : Attribute {

    /// <summary>
    /// Initializes a new instance of the <see cref="AllowNullAttribute"/> class.
    /// </summary>
    public AllowNullAttribute() {
    }

}
