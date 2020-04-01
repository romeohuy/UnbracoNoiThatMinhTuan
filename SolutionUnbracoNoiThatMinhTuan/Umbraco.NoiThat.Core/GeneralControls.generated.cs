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
	// Mixin Content Type with alias "generalControls"
	/// <summary>General Controls</summary>
	public partial interface IGeneralControls : IPublishedContent
	{
		/// <summary>PageMainDescription</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		IHtmlString PageMainDescription { get; }

		/// <summary>PageMainImage</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		IPublishedContent PageMainImage { get; }

		/// <summary>Page Short Content</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		IHtmlString PageShortContent { get; }

		/// <summary>PageTitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string PageTitle { get; }

		/// <summary>umbracoNaviHide</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		bool UmbracoNaviHide { get; }
	}

	/// <summary>General Controls</summary>
	[PublishedModel("generalControls")]
	public partial class GeneralControls : PublishedContentModel, IGeneralControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "generalControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GeneralControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public GeneralControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// PageMainDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pageMainDescription")]
		public IHtmlString PageMainDescription => GetPageMainDescription(this);

		/// <summary>Static getter for PageMainDescription</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IHtmlString GetPageMainDescription(IGeneralControls that) => that.Value<IHtmlString>("pageMainDescription");

		///<summary>
		/// PageMainImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pageMainImage")]
		public IPublishedContent PageMainImage => GetPageMainImage(this);

		/// <summary>Static getter for PageMainImage</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedContent GetPageMainImage(IGeneralControls that) => that.Value<IPublishedContent>("pageMainImage");

		///<summary>
		/// Page Short Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pageShortContent")]
		public IHtmlString PageShortContent => GetPageShortContent(this);

		/// <summary>Static getter for Page Short Content</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IHtmlString GetPageShortContent(IGeneralControls that) => that.Value<IHtmlString>("pageShortContent");

		///<summary>
		/// PageTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => GetPageTitle(this);

		/// <summary>Static getter for PageTitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetPageTitle(IGeneralControls that) => that.Value<string>("pageTitle");

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide => GetUmbracoNaviHide(this);

		/// <summary>Static getter for umbracoNaviHide</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static bool GetUmbracoNaviHide(IGeneralControls that) => that.Value<bool>("umbracoNaviHide");
	}
}
