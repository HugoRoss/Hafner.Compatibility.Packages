// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#pragma warning disable CA1051 // Do not declare visible instance fields

namespace System.Runtime.CompilerServices;

using System.ComponentModel;

/// <summary>
/// Reserved for use by a compiler for tracking metadata.
/// This attribute should not be used by developers in source code.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
[AttributeUsage(AttributeTargets.Module, Inherited = false)]
public sealed class NullablePublicOnlyAttribute : Attribute {

    /// <summary>Initializes the attribute.</summary>
    /// <param name="value">Indicates whether metadata for internal members is included.</param>
    public NullablePublicOnlyAttribute(bool value) {
        IncludesInternals = value;
    }

    /// <summary>Indicates whether metadata for internal members is included.</summary>
    public readonly bool IncludesInternals;

}
