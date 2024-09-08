#pragma warning disable IDE0130 //Namespace does not match folder structure

/********************************************************************************************************************************
 * Credits to Microsoft who provided the code this file is based on through their reference source repository, see
 * "https://referencesource.microsoft.com/#mscorlib/system/runtime/interopservices/attributes.cs,e803ebb9a4b76468".
 * The original file is MIT licensed.
 ********************************************************************************************************************************/

// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////

namespace System.Runtime.InteropServices;

/// <summary>
/// Supplies an explicit System.Guid when an automatic GUID is undesirable.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Delegate, Inherited = false)]
[ComVisible(true)]
public sealed class GuidAttribute : Attribute {

    /// <summary>Initializes a new instance of the System.Runtime.InteropServices.GuidAttribute class with the specified GUID.</summary>
    /// <param name="guid">The System.Guid to be assigned.</param>
    public GuidAttribute(string guid) {
        Value = guid;
    }

    /// <summary>
    /// Gets the System.Guid of the type or assembly.
    /// </summary>
    public string Value { get; }

}
