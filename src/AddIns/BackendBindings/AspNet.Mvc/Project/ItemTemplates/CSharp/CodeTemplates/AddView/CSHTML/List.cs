﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ICSharpCode.AspNet.Mvc.CSHtml
{
    using ICSharpCode.AspNet.Mvc;
    using System.Collections.Generic;
    using System.Reflection;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class List : ListBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 6 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelDirective()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 8 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
 
	if (MvcHost.IsPartialView) {
		// Do nothing.
	} else if (MvcHost.IsContentPage) {

            
            #line default
            #line hidden
            this.Write("@{\r\n\tViewBag.Title = \"");
            
            #line 14 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MvcHost.ViewName));
            
            #line default
            #line hidden
            this.Write("\";\r\n\tLayout = \"");
            
            #line 15 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MvcHost.MasterPageFile));
            
            #line default
            #line hidden
            this.Write("\";\r\n}\r\n\r\n<h2>");
            
            #line 18 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MvcHost.ViewName));
            
            #line default
            #line hidden
            this.Write("</h2>\r\n\r\n");
            
            #line 20 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"

	} else {

            
            #line default
            #line hidden
            this.Write("<!DOCTYPE html>\r\n<html>\r\n\t<head runat=\"server\">\r\n\t\t<title>");
            
            #line 26 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MvcHost.ViewName));
            
            #line default
            #line hidden
            this.Write("</title>\r\n\t</head>\r\n\t<body>\r\n");
            
            #line 29 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"

		PushIndent("\t\t");
	}

            
            #line default
            #line hidden
            this.Write("<p>\r\n\t@Html.ActionLink(\"Create\", \"Create\")\r\n</p>\r\n<table>\r\n");
            
            #line 37 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"

	if (ModelHasProperties) {

            
            #line default
            #line hidden
            this.Write("\t<tr>\r\n");
            
            #line 41 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"

		foreach (ModelProperty modelProperty in ModelProperties) {
			if (!modelProperty.IsPrimaryKey) {

            
            #line default
            #line hidden
            this.Write("\t\t<th>\r\n\t\t\t@Html.LabelFor(model => model.");
            
            #line 46 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(modelProperty.Name));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t</th>\r\n");
            
            #line 48 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"

			}
		}

            
            #line default
            #line hidden
            this.Write("\t\t<th></th>\r\n\t</tr>\r\n\t\r\n");
            
            #line 55 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"

	} 

            
            #line default
            #line hidden
            this.Write("@foreach (var item in Model) {\r\n\t<tr>\r\n");
            
            #line 60 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"

	if (ModelHasProperties) {
		foreach (ModelProperty modelProperty in ModelProperties) {
			if (!modelProperty.IsPrimaryKey) {

            
            #line default
            #line hidden
            this.Write("\t\t<td>\r\n\t\t\t@Html.DisplayFor(model => model.");
            
            #line 66 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(modelProperty.Name));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t</td>\r\n");
            
            #line 68 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"

			}
		}
	}

            
            #line default
            #line hidden
            this.Write("\t\t<td>\r\n");
            
            #line 74 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
 if (ModelHasPrimaryKey) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t@Html.ActionLink(\"Edit\", \"Edit\", new { id = item.");
            
            #line 75 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ModelPrimaryKeyName));
            
            #line default
            #line hidden
            this.Write(" }) |\r\n\t\t\t@Html.ActionLink(\"Details\", \"Details\", new { id = item.");
            
            #line 76 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ModelPrimaryKeyName));
            
            #line default
            #line hidden
            this.Write(" }) |\r\n\t\t\t@Html.ActionLink(\"Delete\", \"Delete\", new { id = item.");
            
            #line 77 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ModelPrimaryKeyName));
            
            #line default
            #line hidden
            this.Write(" })\r\n");
            
            #line 78 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\t\t\t@Html.ActionLink(\"Edit\", \"Edit\") |\r\n\t\t\t@Html.ActionLink(\"Details\", \"Details\") " +
                    "|\r\n\t\t\t@Html.ActionLink(\"Delete\", \"Delete\")\r\n");
            
            #line 82 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t</td>\r\n\t</tr>\r\n}\r\n</table>\r\n");
            
            #line 87 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
 
	if (MvcHost.IsPartialView) {
		// Do nothing.
	} else if (!MvcHost.IsContentPage) {
		PopIndent();

            
            #line default
            #line hidden
            this.Write("\t</body>\r\n</html>\r\n");
            
            #line 95 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"
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
        
        #line 96 "F:\repos\SharpDevelop\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\List.tt"

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
	
	public string GetModelDirective()
	{
		string viewDataTypeName = MvcHost.ViewDataTypeName;
		if (!String.IsNullOrEmpty(viewDataTypeName)) {
			return String.Format("@model IEnumerable<{0}>", viewDataTypeName);
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
