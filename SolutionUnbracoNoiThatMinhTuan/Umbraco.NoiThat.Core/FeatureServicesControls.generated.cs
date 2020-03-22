//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.NoiThat.Core
{
	// Mixin Content Type with alias "featureServicesControls"
	/// <summary>Feature Services Controls</summary>
	public partial interface IFeatureServicesControls : IPublishedContent
	{
		/// <summary>Feature Service ContentList</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		IEnumerable<FeatureServiceContentItem> FeatureServiceContentList { get; }

		/// <summary>Feature Service Intro</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string FeatureServiceIntro { get; }
	}

	/// <summary>Feature Services Controls</summary>
	[PublishedModel("featureServicesControls")]
	public partial class FeatureServicesControls : PublishedContentModel, IFeatureServicesControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "featureServicesControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FeatureServicesControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public FeatureServicesControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Feature Service ContentList
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("featureServiceContentList")]
		public IEnumerable<FeatureServiceContentItem> FeatureServiceContentList => GetFeatureServiceContentList(this);

		/// <summary>Static getter for Feature Service ContentList</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IEnumerable<FeatureServiceContentItem> GetFeatureServiceContentList(IFeatureServicesControls that) => that.Value<IEnumerable<FeatureServiceContentItem>>("featureServiceContentList");

		///<summary>
		/// Feature Service Intro
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("featureServiceIntro")]
		public string FeatureServiceIntro => GetFeatureServiceIntro(this);

		/// <summary>Static getter for Feature Service Intro</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetFeatureServiceIntro(IFeatureServicesControls that) => that.Value<string>("featureServiceIntro");
	}
}
