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
	// Mixin Content Type with alias "serviceImageItem"
	/// <summary>Service Image Item</summary>
	public partial interface IServiceImageItem : IPublishedElement
	{
		/// <summary>Image Decription</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string ImageDecription { get; }

		/// <summary>Image Header</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string ImageHeader { get; }

		/// <summary>Image Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		Umbraco.Web.Models.Link ImageLink { get; }

		/// <summary>Image Source</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		IPublishedContent ImageSource { get; }
	}

	/// <summary>Service Image Item</summary>
	[PublishedModel("serviceImageItem")]
	public partial class ServiceImageItem : PublishedElementModel, IServiceImageItem
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "serviceImageItem";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ServiceImageItem, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ServiceImageItem(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Image Decription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("imageDecription")]
		public string ImageDecription => GetImageDecription(this);

		/// <summary>Static getter for Image Decription</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetImageDecription(IServiceImageItem that) => that.Value<string>("imageDecription");

		///<summary>
		/// Image Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("imageHeader")]
		public string ImageHeader => GetImageHeader(this);

		/// <summary>Static getter for Image Header</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetImageHeader(IServiceImageItem that) => that.Value<string>("imageHeader");

		///<summary>
		/// Image Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("imageLink")]
		public Umbraco.Web.Models.Link ImageLink => GetImageLink(this);

		/// <summary>Static getter for Image Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static Umbraco.Web.Models.Link GetImageLink(IServiceImageItem that) => that.Value<Umbraco.Web.Models.Link>("imageLink");

		///<summary>
		/// Image Source
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("imageSource")]
		public IPublishedContent ImageSource => GetImageSource(this);

		/// <summary>Static getter for Image Source</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedContent GetImageSource(IServiceImageItem that) => that.Value<IPublishedContent>("imageSource");
	}
}
