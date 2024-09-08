#pragma warning disable IDE0130 //Namespace does not match folder structure

namespace System.Runtime.CompilerServices;

/// <summary>Indicates that a method is an extension method, or that a class or assembly contains extension methods.</summary>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
public sealed class ExtensionAttribute : Attribute {

    /// <summary>Initializes a new instance of the System.Runtime.CompilerServices.ExtensionAttribute class.</summary>
    public ExtensionAttribute() {
    }

}
