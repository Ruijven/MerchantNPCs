using System.Runtime.CompilerServices;

// Add assembly binding redirect for YamlDotNet
#pragma warning disable 0436
[assembly: IgnoresAccessChecksTo("YamlDotNet")]
#pragma warning restore 0436

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class IgnoresAccessChecksToAttribute : Attribute
    {
        public IgnoresAccessChecksToAttribute(string assemblyName)
        {
            AssemblyName = assemblyName;
        }

        public string AssemblyName { get; }
    }
}
