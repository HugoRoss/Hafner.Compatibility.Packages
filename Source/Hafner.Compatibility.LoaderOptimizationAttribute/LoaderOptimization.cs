// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System;

using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Design", "CA1069:Enums values should not be duplicated", Justification = "That's how it is defined.")]
public enum LoaderOptimization {

    [Obsolete("LoaderOptimization.DisallowBindings has been deprecated and is not supported.")]
    DisallowBindings = 4,
    [Obsolete("LoaderOptimization.DomainMask has been deprecated and is not supported.")]
    DomainMask = 3,
    MultiDomain = 2,
    MultiDomainHost = 3,
    NotSpecified = 0,
    SingleDomain = 1,

}
