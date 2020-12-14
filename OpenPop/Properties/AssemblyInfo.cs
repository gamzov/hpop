using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: InternalsVisibleTo("OpenPopUnitTests")]

// The Assembly is compliant to CLS rules
[assembly: CLSCompliant(true)]

// Allow that assemblies can reference this assembly
// even though they do not have the FullTrust priviledge.
// This will not defeat security, since normal security policies
// like DNS, IO permissions are still in effect
[assembly: AllowPartiallyTrustedCallers]

// This is the configuration when building the assembly
[assembly: AssemblyConfiguration("Release mode assembly. Built for .NET 2.0")]
[assembly: AssemblyTrademark("OpenPop")]
