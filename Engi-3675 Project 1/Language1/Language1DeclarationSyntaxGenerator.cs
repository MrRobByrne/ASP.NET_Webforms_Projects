using System;
using System.IO;
using System.Reflection;
using System.Xml.XPath;

using Sandcastle.Core.BuildAssembler.SyntaxGenerator;

// Search for "TODO" to find changes that you need to make to this syntax generator template.

namespace Language1
{
    /// <summary>
    /// TODO: Set your syntax generator's unique ID and description in the export attribute in the factory class
    /// below.
    /// </summary>
    /// <remarks>The <c>SyntaxGeneratorExportAttribute</c> is used to export your syntax generator so that the
    /// help file builder finds it and can make use of it.  The example below shows the basic usage for a common
    /// syntax generator.  Multiple copies of syntax generators can be created depending on their usage.  The
    /// host process will create instances as needed.
    ///
    /// <para>NOTE: For non-languages, a simpler base type, <c>SyntaxGeneratorCore</c>, may be used.  An example
    /// of its use can be found in the <c>AspNetSyntaxGenerator</c>.</para></remarks>
    public class Language1DeclarationSyntaxGenerator : SyntaxGeneratorTemplate
    {
        #region Syntax generator factory for MEF
        //=====================================================================

        // TODO: Set the unique style ID name.
        // NOTE: If you change LanguageName, rename the SyntaxContent\Language1.xml file to the same name
        //       and update the IDs of the content items in it with the new name.
        private const string LanguageName = "Language1", StyleIdName = "xyz";

        /// <summary>
        /// This is used to create a new instance of the syntax generator
        /// </summary>
        /// <remarks>The <c>keywordStyleParameter</c> parameter is used to set the keyword style in the
        /// presentation style and should unique to your programming language.  Set the additional attributes as
        /// needed:
        ///
        /// <list type="bullet">
        ///     <item>
        ///         <term>AlternateIds</term>
        ///         <description>Specify a comma-separated list of other language names that can be mapped to
        /// this generator.</description>
        ///     </item>
        ///     <item>
        ///         <term>IsConfigurable</term>
        ///         <description>Set this to true if your syntax generator contains configurable settings.
        /// Designers can use the <c>DefaultConfiguration</c> property to obtain the default configuration.</description>
        ///     </item>
        ///     <item>
        ///         <term>DefaultConfiguration</term>
        ///         <description>If your syntax generator has configurable settings, use this property to specify
        /// the default settings in an XML fragment.</description>
        ///     </item>
        /// </list>
        /// </remarks>
        [SyntaxGeneratorExport("Language1", LanguageName, StyleIdName, SortOrder = 500,
          Version = AssemblyInfo.ProductVersion, Copyright = AssemblyInfo.Copyright,
          Description = "Generates Language1 declaration syntax sections")]
        public sealed class Factory : ISyntaxGeneratorFactory
        {
            /// <inheritdoc />
            public string ResourceItemFileLocation
            {
                get
                {
                    return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SyntaxContent");
                }
            }

            /// <inheritdoc />
            public SyntaxGeneratorCore Create()
            {
                return new Language1DeclarationSyntaxGenerator { Language = LanguageName, StyleId = StyleIdName };
            }
        }
        #endregion

        #region Abstract method implementations
        //=====================================================================

        // TODO: Each of the following methods must be implemented.  Syntax generation is rather complex.
        // It may be best to copy one of the existing syntax generators if the language is a close match
        // for the one you are trying to implement.

        /// <inheritdoc />
        public override void WriteClassSyntax(XPathNavigator reflection, SyntaxWriter writer)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public override void WriteConstructorSyntax(XPathNavigator reflection, SyntaxWriter writer)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public override void WriteDelegateSyntax(XPathNavigator reflection, SyntaxWriter writer)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public override void WriteEnumerationSyntax(XPathNavigator reflection, SyntaxWriter writer)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public override void WriteEventSyntax(XPathNavigator reflection, SyntaxWriter writer)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public override void WriteFieldSyntax(XPathNavigator reflection, SyntaxWriter writer)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public override void WriteInterfaceSyntax(XPathNavigator reflection, SyntaxWriter writer)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public override void WriteNamespaceSyntax(XPathNavigator reflection, SyntaxWriter writer)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public override void WritePropertySyntax(XPathNavigator reflection, SyntaxWriter writer)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public override void WriteStructureSyntax(XPathNavigator reflection, SyntaxWriter writer)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
