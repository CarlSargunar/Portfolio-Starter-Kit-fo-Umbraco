//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>CV</summary>
	[PublishedModel("cV")]
	public partial class CV : PublishedContentModel, ISEocontrols, IVisibilityControls, IWorkHistoryControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		public new const string ModelTypeAlias = "cV";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<CV, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public CV(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Canonical Url: Enter the canonical url for this page. If it is empty, the url of the page will be used instead.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("canonicalUrl")]
		public virtual string CanonicalUrl => global::Umbraco.Cms.Web.Common.PublishedModels.SEocontrols.GetCanonicalUrl(this, _publishedValueFallback);

		///<summary>
		/// Meta Description: Enter the meta description for the page. This is what will show in search engine results.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("metaDescription")]
		public virtual string MetaDescription => global::Umbraco.Cms.Web.Common.PublishedModels.SEocontrols.GetMetaDescription(this, _publishedValueFallback);

		///<summary>
		/// Meta Title: Enter the title for the page. If this is blank, we will use page title. If that is blank we will use page name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("metaTitle")]
		public virtual string MetaTitle => global::Umbraco.Cms.Web.Common.PublishedModels.SEocontrols.GetMetaTitle(this, _publishedValueFallback);

		///<summary>
		/// Hide: Set this to true if you want to hide this page from the navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("umbracoNaviHide")]
		public virtual bool UmbracoNaviHide => global::Umbraco.Cms.Web.Common.PublishedModels.VisibilityControls.GetUmbracoNaviHide(this, _publishedValueFallback);

		///<summary>
		/// Contact Info: Enter the contact info
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("contactInfo")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedElement> ContactInfo => global::Umbraco.Cms.Web.Common.PublishedModels.WorkHistoryControls.GetContactInfo(this, _publishedValueFallback);

		///<summary>
		/// Contact Info Title: Enter the title for the contact info section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("contactInfoTitle")]
		public virtual string ContactInfoTitle => global::Umbraco.Cms.Web.Common.PublishedModels.WorkHistoryControls.GetContactInfoTitle(this, _publishedValueFallback);

		///<summary>
		/// Education History: Enter the details of your education
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("educationHistory")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.HistoryItem> EducationHistory => global::Umbraco.Cms.Web.Common.PublishedModels.WorkHistoryControls.GetEducationHistory(this, _publishedValueFallback);

		///<summary>
		/// Education History Title: Enter the title for the education history section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("educationHistoryTitle")]
		public virtual string EducationHistoryTitle => global::Umbraco.Cms.Web.Common.PublishedModels.WorkHistoryControls.GetEducationHistoryTitle(this, _publishedValueFallback);

		///<summary>
		/// Hobbies: Enter the content for the hobbies section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("hobbies")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Hobbies => global::Umbraco.Cms.Web.Common.PublishedModels.WorkHistoryControls.GetHobbies(this, _publishedValueFallback);

		///<summary>
		/// Hobbies Title: Enter a title for the hobbies section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("hobbiesTitle")]
		public virtual string HobbiesTitle => global::Umbraco.Cms.Web.Common.PublishedModels.WorkHistoryControls.GetHobbiesTitle(this, _publishedValueFallback);

		///<summary>
		/// Skills: Enter your skills and ratings
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("skills")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.SkillItem> Skills => global::Umbraco.Cms.Web.Common.PublishedModels.WorkHistoryControls.GetSkills(this, _publishedValueFallback);

		///<summary>
		/// Skills Title: Enter the title for the skills section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("skillsTitle")]
		public virtual string SkillsTitle => global::Umbraco.Cms.Web.Common.PublishedModels.WorkHistoryControls.GetSkillsTitle(this, _publishedValueFallback);

		///<summary>
		/// Work History: Enter the details of the places you have worked at
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("workHistory")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.HistoryItem> WorkHistory => global::Umbraco.Cms.Web.Common.PublishedModels.WorkHistoryControls.GetWorkHistory(this, _publishedValueFallback);

		///<summary>
		/// Work History Title: Enter the title for the work history section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("workHistoryTitle")]
		public virtual string WorkHistoryTitle => global::Umbraco.Cms.Web.Common.PublishedModels.WorkHistoryControls.GetWorkHistoryTitle(this, _publishedValueFallback);
	}
}