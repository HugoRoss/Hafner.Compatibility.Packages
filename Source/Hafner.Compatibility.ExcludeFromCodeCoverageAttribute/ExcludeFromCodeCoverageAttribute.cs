﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Diagnostics.CodeAnalysis;

using static AttributeTargets;

[AttributeUsage(Assembly | Class | Struct | Constructor | Method | Property | Event, Inherited = false, AllowMultiple = false)]
public sealed class ExcludeFromCodeCoverageAttribute : Attribute {

    public ExcludeFromCodeCoverageAttribute() {
    }

    /// <summary>Gets or sets the justification for excluding the member from code coverage.</summary>
    public string? Justification { get; set; }

}
