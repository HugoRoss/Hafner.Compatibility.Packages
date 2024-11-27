namespace System.Diagnostics.CodeAnalysis;

using System;

/// <summary>
/// Indicates that the specified method parameter expects a constant.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
public sealed class ConstantExpectedAttribute : Attribute {

    /// <summary>
    /// Initializes a new instance of the System.Diagnostics.CodeAnalysis.ConstantExpectedAttribute class.
    /// </summary>
    public ConstantExpectedAttribute() {
    }

    /// <summary>Gets or sets the minimum bound of the expected constant, inclusive.</summary>
    public object? Min { get; set; }

    /// <summary>Gets or sets the maximum bound of the expected constant, inclusive.</summary>
    public object? Max { get; set; }

}
