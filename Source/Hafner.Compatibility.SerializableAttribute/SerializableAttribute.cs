#pragma warning disable IDE0130 //Namespace does not match folder structure

// Loosely based on https://github.com/microsoft/referencesource/blob/master/mscorlib/system/serializableattribute.cs

// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==

namespace System;

using System.Runtime.InteropServices;

/// <summary>
/// Indicates that a class can be serialized using binary or XML serialization. This class cannot be inherited.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
[ComVisible(true)]
public sealed class SerializableAttribute : Attribute {

    /// <summary>
    /// Initializes a new instance of the <see cref="SerializableAttribute"/> class.
    /// </summary>
    public SerializableAttribute() {
    }

}
