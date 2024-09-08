// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#pragma warning disable CA1051 // Do not declare visible instance fields

namespace System.Runtime.CompilerServices;

using System;

using System.ComponentModel;

/// <summary>
/// Reserved for use by a compiler for tracking metadata. This attribute should not be used by developers in source code.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class NullableContextAttribute : Attribute {

    /// <summary>
    /// Initializes the attribute.
    /// </summary>
    /// <param name="value">The flag value.</param>
    public NullableContextAttribute(byte value) {
        Flag = value;
    }

    /// <summary>
    /// Specifies metadata related to nullable reference types.
    /// </summary>
    public readonly byte Flag;

}
