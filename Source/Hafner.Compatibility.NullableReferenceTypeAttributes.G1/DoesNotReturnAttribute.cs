namespace System.Diagnostics.CodeAnalysis;

using System;

/// <summary>
/// Specifies that a method will not return under any circumstance, or in other words, it always throws an <see cref="Exception"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class DoesNotReturnAttribute : Attribute {

    /// <summary>
    /// Initializes a new instance of the <see cref="DoesNotReturnAttribute"/> class.
    /// </summary>
    public DoesNotReturnAttribute() {
    }

}
