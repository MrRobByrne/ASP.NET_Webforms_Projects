using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

// General assembly information
[assembly: AssemblyProduct("Language1")]
[assembly: AssemblyTitle("Language1")]
[assembly: AssemblyDescription("A syntax generator for use with the SyntaxComponent in BuildAssembler")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyCopyright(AssemblyInfo.Copyright)]
[assembly: AssemblyCulture("")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: ComVisible(false)]

[assembly: CLSCompliant(true)]

// Resources contained within the assembly are English
[assembly: NeutralResourcesLanguageAttribute("en")]

[assembly: AssemblyVersion(AssemblyInfo.ProductVersion)]
[assembly: AssemblyFileVersion(AssemblyInfo.ProductVersion)]
[assembly: AssemblyInformationalVersion(AssemblyInfo.ProductVersion)]

// This defines constants that can be used here and in the custom presentation style export attribute
internal static partial class AssemblyInfo
{
    // Product version
    public const string ProductVersion = "1.0.0.0";

    // Assembly copyright information
    public const string Copyright = "Copyright \xA9 2015, , All Rights Reserved.";
}
