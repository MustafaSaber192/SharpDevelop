﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ICSharpCode.AspNet.Mvc.AspxCSharp
{
    using ICSharpCode.AspNet.Mvc;
    using System.Collections.Generic;
    using System.Reflection;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class List : ListBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 5 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
 if (MvcHost.IsPartialView) { 
            
            #line default
            #line hidden
            this.Write("<%@ Control Language=\"C#\" Inherits=\"System.Web.Mvc.ViewUserControl<IEnumerable");
            
            #line 6 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetViewPageType()));
            
            #line default
            #line hidden
            this.Write(">\" %>\r\n\r\n");
            
            #line 8 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
 } else if (MvcHost.IsContentPage) { 
            
            #line default
            #line hidden
            this.Write("<%@ Page Language=\"C#\" MasterPageFile=\"");
            
            #line 9 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MvcHost.MasterPageFile));
            
            #line default
            #line hidden
            this.Write("\" Inherits=\"System.Web.Mvc.ViewPage<IEnumerable");
            
            #line 9 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetViewPageType()));
            
            #line default
            #line hidden
            this.Write(">\" %>\r\n\r\n<asp:Content ID=\"Content1\" ContentPlaceHolderID=\"Title\" runat=\"server\">\r" +
                    "\n");
            
            #line 12 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MvcHost.ViewName));
            
            #line default
            #line hidden
            this.Write("\r\n</asp:Content>\r\n\r\n<asp:Content ID=\"Content2\" ContentPlaceHolderID=\"");
            
            #line 15 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MvcHost.PrimaryContentPlaceHolderID));
            
            #line default
            #line hidden
            this.Write("\" runat=\"server\">\r\n");
            
            #line 16 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

		PushIndent("\t");
	} else {

            
            #line default
            #line hidden
            this.Write("<%@ Page Language=\"C#\" Inherits=\"System.Web.Mvc.ViewPage<IEnumerable");
            
            #line 20 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetViewPageType()));
            
            #line default
            #line hidden
            this.Write(">\" %>\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n\t<head runat=\"server\">\r\n\t\t<title>");
            
            #line 25 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MvcHost.ViewName));
            
            #line default
            #line hidden
            this.Write("</title>\r\n\t</head>\r\n\t<body>\r\n");
            
            #line 28 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
 
		PushIndent("\t\t");
	} 

            
            #line default
            #line hidden
            this.Write("<p>\r\n\t<%: Html.ActionLink(\"Create\", \"Create\") %>\r\n</p>\r\n<table>\r\n");
            
            #line 36 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

	if (ModelHasProperties) {

            
            #line default
            #line hidden
            this.Write("\t<tr>\r\n");
            
            #line 40 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

		foreach (ModelProperty modelProperty in ModelProperties) {
			if (!modelProperty.IsPrimaryKey) {

            
            #line default
            #line hidden
            this.Write("\t\t<th>\r\n\t\t\t<%: Html.LabelFor(model => model.");
            
            #line 45 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(modelProperty.Name));
            
            #line default
            #line hidden
            this.Write(") %>\r\n\t\t</th>\r\n");
            
            #line 47 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

			}
		}

            
            #line default
            #line hidden
            this.Write("\t\t<th></th>\r\n\t</tr>\r\n\t\r\n");
            
            #line 54 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

	} 

            
            #line default
            #line hidden
            this.Write("<% foreach (var item in Model) { %>\r\n\t<tr>\r\n");
            
            #line 59 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

	if (ModelHasProperties) {
		foreach (ModelProperty modelProperty in ModelProperties) {
			if (!modelProperty.IsPrimaryKey) {

            
            #line default
            #line hidden
            this.Write("\t\t<td>\r\n\t\t\t<%: Html.DisplayFor(model => model.");
            
            #line 65 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(modelProperty.Name));
            
            #line default
            #line hidden
            this.Write(") %>\r\n\t\t</td>\r\n");
            
            #line 67 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

			}
		}
	}

            
            #line default
            #line hidden
            this.Write("\t\t<td>\r\n");
            
            #line 73 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
 if (ModelHasPrimaryKey) {
            
            #line default
            #line hidden
            this.Write("\t\t\t<%: Html.ActionLink(\"Edit\", \"Edit\", new { id = item.");
            
            #line 74 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ModelPrimaryKeyName));
            
            #line default
            #line hidden
            this.Write(" }) %> |\r\n\t\t\t<%: Html.ActionLink(\"Details\", \"Details\", new { id = item.");
            
            #line 75 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ModelPrimaryKeyName));
            
            #line default
            #line hidden
            this.Write(" }) %> |\r\n\t\t\t<%: Html.ActionLink(\"Delete\", \"Delete\", new { id = item.");
            
            #line 76 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ModelPrimaryKeyName));
            
            #line default
            #line hidden
            this.Write(" }) %>\r\n");
            
            #line 77 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\t\t\t<%: Html.ActionLink(\"Edit\", \"Edit\") %> |\r\n\t\t\t<%: Html.ActionLink(\"Details\", \"D" +
                    "etails\") %> |\r\n\t\t\t<%: Html.ActionLink(\"Delete\", \"Delete\") %>\r\n");
            
            #line 81 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t</td>\r\n\t</tr>\r\n<% } %>\r\n</table>\r\n");
            
            #line 86 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

	if (MvcHost.IsPartialView) {
		// Do nothing.
	} else if (MvcHost.IsContentPage) {
		PopIndent();

            
            #line default
            #line hidden
            this.Write("</asp:Content>\r\n");
            
            #line 93 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

	} else { 
		PopIndent();

            
            #line default
            #line hidden
            this.Write("\t</body>\r\n</html>\r\n");
            
            #line 99 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        private global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost hostValue;
        /// <summary>
        /// The current host for the text templating engine
        /// </summary>
        public virtual global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost Host
        {
            get
            {
                return this.hostValue;
            }
            set
            {
                this.hostValue = value;
            }
        }
        
        #line 100 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

	MvcTextTemplateHost MvcHost {
		get { return (MvcTextTemplateHost)Host; }
	}
	
	public class ModelProperty
	{
		public string Name { get; set; }
		public bool IsPrimaryKey { get; set; }
		
		public ModelProperty(PropertyInfo propertyInfo)
		{
			this.Name = propertyInfo.Name;
			this.IsPrimaryKey = IsPrimaryKeyProperty(propertyInfo);
		}
		
		bool IsPrimaryKeyProperty(PropertyInfo propertyInfo)
		{
			return
				IsIdProperty(propertyInfo) ||
				IsIdPropertyPrefixedWithClassName(propertyInfo);
		}
		
		bool IsIdProperty(PropertyInfo propertyInfo)
		{
			return IsMatchIgnoringCase(propertyInfo.Name, "id");
		}
		
		bool IsIdPropertyPrefixedWithClassName(PropertyInfo propertyInfo)
		{
			string prefixedIdPropertyName = propertyInfo.DeclaringType.Name + "id";
			return IsMatchIgnoringCase(propertyInfo.Name, prefixedIdPropertyName);
		}
		
		static bool IsMatchIgnoringCase(string a, string b)
		{
			return String.Equals(a, b, StringComparison.OrdinalIgnoreCase);
		}
	}
	
	public string GetViewPageType()
	{
		string viewDataTypeName = MvcHost.ViewDataTypeName;
		if (!String.IsNullOrEmpty(viewDataTypeName)) {
			return String.Format("<{0}>", viewDataTypeName);
		}
		return String.Empty;
	}
	
	List<ModelProperty> modelProperties;
	
	List<ModelProperty> ModelProperties {
		get {
			if (modelProperties == null) {
				modelProperties = new List<ModelProperty>(GetModelProperties());
			}
			return modelProperties;
		}
	}
	
	public IEnumerable<ModelProperty> GetModelProperties()
	{
		var properties = new List<ModelProperty>();
		foreach (PropertyInfo propertyInfo in MvcHost.GetViewDataTypeProperties()) {
			properties.Add(new ModelProperty(propertyInfo));
		}
		return properties;
	}
	
	bool ModelHasProperties {
		get { return ModelProperties.Count > 0; }
	}
	
	bool ModelHasPrimaryKey {
		get { return ModelPrimaryKeyName.Length > 0; }
	}
	
	string modelPrimaryKeyName;
	
	string ModelPrimaryKeyName {
		get {
			if (modelPrimaryKeyName == null) {
				modelPrimaryKeyName = GetModelPrimaryKeyName();
			}
			return modelPrimaryKeyName;
		}
	}
	
	public string GetModelPrimaryKeyName()
	{
		foreach (ModelProperty modelProperty in ModelProperties) {
			if (modelProperty.IsPrimaryKey) {
				return modelProperty.Name;
			}
		}
		return "";
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class ListBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        public System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
