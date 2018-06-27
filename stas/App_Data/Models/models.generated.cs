//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
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

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "70fa1dafe7be9440")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.2")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Master</summary>
	[PublishedContentModel("master")]
	public partial class Master : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "master";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Master(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Master, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Html Title: SEO: HTML Title
		///</summary>
		[ImplementPropertyType("htmlTitle")]
		public string HtmlTitle
		{
			get { return this.GetPropertyValue<string>("htmlTitle"); }
		}

		///<summary>
		/// Meta Description: SEO: Meta tags n description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return this.GetPropertyValue<string>("metaDescription"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// about images: foto #1 om te tonen op de about sectie van de homepagina
		///</summary>
		[ImplementPropertyType("aboutImages")]
		public IEnumerable<IPublishedContent> AboutImages
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("aboutImages"); }
		}

		///<summary>
		/// AboutText: Text in de about sectie van de homepagina
		///</summary>
		[ImplementPropertyType("aboutText")]
		public IHtmlString AboutText
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutText"); }
		}

		///<summary>
		/// About Title: title op de about us sectie van de home pagina
		///</summary>
		[ImplementPropertyType("aboutTitle")]
		public string AboutTitle
		{
			get { return this.GetPropertyValue<string>("aboutTitle"); }
		}

		///<summary>
		/// Contact Adres: Adres veld op de contact banner van de homepagina
		///</summary>
		[ImplementPropertyType("contactAdres")]
		public string ContactAdres
		{
			get { return this.GetPropertyValue<string>("contactAdres"); }
		}

		///<summary>
		/// Contact Email: Email op de contactbox van de homepagina
		///</summary>
		[ImplementPropertyType("contactEmail")]
		public string ContactEmail
		{
			get { return this.GetPropertyValue<string>("contactEmail"); }
		}

		///<summary>
		/// Contact Telefoon: Telefoon nummer op de de contact box van de homepagina
		///</summary>
		[ImplementPropertyType("contactTelefoon")]
		public string ContactTelefoon
		{
			get { return this.GetPropertyValue<string>("contactTelefoon"); }
		}

		///<summary>
		/// Contact Title: Title op de contact box op de home pagina
		///</summary>
		[ImplementPropertyType("contactTitle")]
		public string ContactTitle
		{
			get { return this.GetPropertyValue<string>("contactTitle"); }
		}

		///<summary>
		/// HomeBannerText: Bouncy text op de homepagina
		///</summary>
		[ImplementPropertyType("homeBannerText")]
		public string HomeBannerText
		{
			get { return this.GetPropertyValue<string>("homeBannerText"); }
		}

		///<summary>
		/// Home Landing Image: kies een foto om op de home pagina te tonen
		///</summary>
		[ImplementPropertyType("homeLandingImage")]
		public IPublishedContent HomeLandingImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("homeLandingImage"); }
		}
	}

	/// <summary>About STAS</summary>
	[PublishedContentModel("aboutUs")]
	public partial class AboutUs : Master, IBannerItems, ITitle
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "aboutUs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AboutUs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AboutUs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// About Text kolom 1: het linker kolom met text van de about us pagina
		///</summary>
		[ImplementPropertyType("aboutTextCol1")]
		public IHtmlString AboutTextCol1
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutTextCol1"); }
		}

		///<summary>
		/// about Text kolom 2: het rechter kolom met text van de about us pagina
		///</summary>
		[ImplementPropertyType("aboutTextCol2")]
		public IHtmlString AboutTextCol2
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutTextCol2"); }
		}

		///<summary>
		/// Banner author: naam van author van de quote in de zwarte balk
		///</summary>
		[ImplementPropertyType("bannerAuthor")]
		public string BannerAuthor
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetBannerAuthor(this); }
		}

		///<summary>
		/// Banner Image: Banner foto
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetBannerImage(this); }
		}

		///<summary>
		/// WitteBox: tekst om in de witte box op de banner te plaatsen
		///</summary>
		[ImplementPropertyType("witteBox")]
		public string WitteBox
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetWitteBox(this); }
		}

		///<summary>
		/// ZwarteText: text in zwarte box op banner
		///</summary>
		[ImplementPropertyType("zwarteText")]
		public string ZwarteText
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetZwarteText(this); }
		}

		///<summary>
		/// Subtitle: subtitle voor de title onder de banner
		///</summary>
		[ImplementPropertyType("subtitle")]
		public IHtmlString Subtitle
		{
			get { return Umbraco.Web.PublishedContentModels.Title.GetSubtitle(this); }
		}

		///<summary>
		/// Title: title onder banner
		///</summary>
		[ImplementPropertyType("titleText")]
		public string TitleText
		{
			get { return Umbraco.Web.PublishedContentModels.Title.GetTitleText(this); }
		}
	}

	/// <summary>Corporate Identities</summary>
	[PublishedContentModel("corporateIdentities")]
	public partial class CorporateIdentities : Master, IBannerItems, ITitle
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "corporateIdentities";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CorporateIdentities(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CorporateIdentities, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// bekijk Portfolio: link om portfolio te gaan bekijken
		///</summary>
		[ImplementPropertyType("bekijkPortfolio")]
		public Umbraco.Web.Models.RelatedLinks BekijkPortfolio
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("bekijkPortfolio"); }
		}

		///<summary>
		/// Black Box Text: de text inhoud van de zwarte box
		///</summary>
		[ImplementPropertyType("blackBoxText")]
		public IHtmlString BlackBoxText
		{
			get { return this.GetPropertyValue<IHtmlString>("blackBoxText"); }
		}

		///<summary>
		/// Black Box Title: Title van de zwarte box onder de text sectie
		///</summary>
		[ImplementPropertyType("blackBoxTitle")]
		public string BlackBoxTitle
		{
			get { return this.GetPropertyValue<string>("blackBoxTitle"); }
		}

		///<summary>
		/// Subtitle2: 2e subtitle
		///</summary>
		[ImplementPropertyType("subtitle2")]
		public string Subtitle2
		{
			get { return this.GetPropertyValue<string>("subtitle2"); }
		}

		///<summary>
		/// Subtitle3: 3e subtitle onder 3e title
		///</summary>
		[ImplementPropertyType("subtitle3")]
		public string Subtitle3
		{
			get { return this.GetPropertyValue<string>("subtitle3"); }
		}

		///<summary>
		/// text: text onder 1ste titel en subtitle
		///</summary>
		[ImplementPropertyType("text")]
		public IHtmlString Text
		{
			get { return this.GetPropertyValue<IHtmlString>("text"); }
		}

		///<summary>
		/// text2: text onder 2e titel en subtitle
		///</summary>
		[ImplementPropertyType("text2")]
		public IHtmlString Text2
		{
			get { return this.GetPropertyValue<IHtmlString>("text2"); }
		}

		///<summary>
		/// text3: text onder 3e title en subtitle
		///</summary>
		[ImplementPropertyType("text3")]
		public IHtmlString Text3
		{
			get { return this.GetPropertyValue<IHtmlString>("text3"); }
		}

		///<summary>
		/// Title2: 2e title onder banner
		///</summary>
		[ImplementPropertyType("title2")]
		public string Title2
		{
			get { return this.GetPropertyValue<string>("title2"); }
		}

		///<summary>
		/// Title3: 3e title
		///</summary>
		[ImplementPropertyType("title3")]
		public string Title3
		{
			get { return this.GetPropertyValue<string>("title3"); }
		}

		///<summary>
		/// Banner author: naam van author van de quote in de zwarte balk
		///</summary>
		[ImplementPropertyType("bannerAuthor")]
		public string BannerAuthor
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetBannerAuthor(this); }
		}

		///<summary>
		/// Banner Image: Banner foto
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetBannerImage(this); }
		}

		///<summary>
		/// WitteBox: tekst om in de witte box op de banner te plaatsen
		///</summary>
		[ImplementPropertyType("witteBox")]
		public string WitteBox
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetWitteBox(this); }
		}

		///<summary>
		/// ZwarteText: text in zwarte box op banner
		///</summary>
		[ImplementPropertyType("zwarteText")]
		public string ZwarteText
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetZwarteText(this); }
		}

		///<summary>
		/// Subtitle: subtitle voor de title onder de banner
		///</summary>
		[ImplementPropertyType("subtitle")]
		public IHtmlString Subtitle
		{
			get { return Umbraco.Web.PublishedContentModels.Title.GetSubtitle(this); }
		}

		///<summary>
		/// Title: title onder banner
		///</summary>
		[ImplementPropertyType("titleText")]
		public string TitleText
		{
			get { return Umbraco.Web.PublishedContentModels.Title.GetTitleText(this); }
		}
	}

	/// <summary>Graphic Design</summary>
	[PublishedContentModel("graphicDesign")]
	public partial class GraphicDesign : Master, IBannerItems, ITitle
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "graphicDesign";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GraphicDesign(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GraphicDesign, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Adobe CC: adobe CC title onder Adobe CC image
		///</summary>
		[ImplementPropertyType("adobeCC")]
		public string AdobeCC
		{
			get { return this.GetPropertyValue<string>("adobeCC"); }
		}

		///<summary>
		/// DTP: DTP onder dtp image
		///</summary>
		[ImplementPropertyType("dTP")]
		public string DTP
		{
			get { return this.GetPropertyValue<string>("dTP"); }
		}

		///<summary>
		/// Graphic Col links: linker kolom van graphics design text
		///</summary>
		[ImplementPropertyType("graphicColLinks")]
		public IHtmlString GraphicColLinks
		{
			get { return this.GetPropertyValue<IHtmlString>("graphicColLinks"); }
		}

		///<summary>
		/// Graphic Col Rechts: Rechter colom van graphic design text
		///</summary>
		[ImplementPropertyType("graphicColRechts")]
		public IHtmlString GraphicColRechts
		{
			get { return this.GetPropertyValue<IHtmlString>("graphicColRechts"); }
		}

		///<summary>
		/// Ontwerp: ontwerp title onder ontwerp image
		///</summary>
		[ImplementPropertyType("ontwerp")]
		public string Ontwerp
		{
			get { return this.GetPropertyValue<string>("ontwerp"); }
		}

		///<summary>
		/// Webdesign: webdesign title onder webdesign image
		///</summary>
		[ImplementPropertyType("webdesign")]
		public string Webdesign
		{
			get { return this.GetPropertyValue<string>("webdesign"); }
		}

		///<summary>
		/// Banner author: naam van author van de quote in de zwarte balk
		///</summary>
		[ImplementPropertyType("bannerAuthor")]
		public string BannerAuthor
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetBannerAuthor(this); }
		}

		///<summary>
		/// Banner Image: Banner foto
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetBannerImage(this); }
		}

		///<summary>
		/// WitteBox: tekst om in de witte box op de banner te plaatsen
		///</summary>
		[ImplementPropertyType("witteBox")]
		public string WitteBox
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetWitteBox(this); }
		}

		///<summary>
		/// ZwarteText: text in zwarte box op banner
		///</summary>
		[ImplementPropertyType("zwarteText")]
		public string ZwarteText
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetZwarteText(this); }
		}

		///<summary>
		/// Subtitle: subtitle voor de title onder de banner
		///</summary>
		[ImplementPropertyType("subtitle")]
		public IHtmlString Subtitle
		{
			get { return Umbraco.Web.PublishedContentModels.Title.GetSubtitle(this); }
		}

		///<summary>
		/// Title: title onder banner
		///</summary>
		[ImplementPropertyType("titleText")]
		public string TitleText
		{
			get { return Umbraco.Web.PublishedContentModels.Title.GetTitleText(this); }
		}
	}

	/// <summary>Film Video</summary>
	[PublishedContentModel("filmVideo")]
	public partial class FilmVideo : Master, IBannerItems, ITitle
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "filmVideo";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public FilmVideo(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FilmVideo, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Film Text Col 1: linker text kolom voor film pagina
		///</summary>
		[ImplementPropertyType("filmTextCol1")]
		public IHtmlString FilmTextCol1
		{
			get { return this.GetPropertyValue<IHtmlString>("filmTextCol1"); }
		}

		///<summary>
		/// Film Text col 2: rechter Text kolom film pagina
		///</summary>
		[ImplementPropertyType("filmTextCol2")]
		public IHtmlString FilmTextCol2
		{
			get { return this.GetPropertyValue<IHtmlString>("filmTextCol2"); }
		}

		///<summary>
		/// Banner author: naam van author van de quote in de zwarte balk
		///</summary>
		[ImplementPropertyType("bannerAuthor")]
		public string BannerAuthor
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetBannerAuthor(this); }
		}

		///<summary>
		/// Banner Image: Banner foto
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetBannerImage(this); }
		}

		///<summary>
		/// WitteBox: tekst om in de witte box op de banner te plaatsen
		///</summary>
		[ImplementPropertyType("witteBox")]
		public string WitteBox
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetWitteBox(this); }
		}

		///<summary>
		/// ZwarteText: text in zwarte box op banner
		///</summary>
		[ImplementPropertyType("zwarteText")]
		public string ZwarteText
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetZwarteText(this); }
		}

		///<summary>
		/// Subtitle: subtitle voor de title onder de banner
		///</summary>
		[ImplementPropertyType("subtitle")]
		public IHtmlString Subtitle
		{
			get { return Umbraco.Web.PublishedContentModels.Title.GetSubtitle(this); }
		}

		///<summary>
		/// Title: title onder banner
		///</summary>
		[ImplementPropertyType("titleText")]
		public string TitleText
		{
			get { return Umbraco.Web.PublishedContentModels.Title.GetTitleText(this); }
		}
	}

	/// <summary>Events</summary>
	[PublishedContentModel("events")]
	public partial class Events : Master, IBannerItems, ITitle
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "events";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Events(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Events, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Concept Text: Text voor concept Item
		///</summary>
		[ImplementPropertyType("conceptText")]
		public IHtmlString ConceptText
		{
			get { return this.GetPropertyValue<IHtmlString>("conceptText"); }
		}

		///<summary>
		/// Concept Title: Title voor concept Item
		///</summary>
		[ImplementPropertyType("conceptTitle")]
		public string ConceptTitle
		{
			get { return this.GetPropertyValue<string>("conceptTitle"); }
		}

		///<summary>
		/// Logistiek Text: Text voor logistiek Item
		///</summary>
		[ImplementPropertyType("logistiekText")]
		public IHtmlString LogistiekText
		{
			get { return this.GetPropertyValue<IHtmlString>("logistiekText"); }
		}

		///<summary>
		/// Logistiek Title: text voor logistiek item
		///</summary>
		[ImplementPropertyType("logistiekTitle")]
		public string LogistiekTitle
		{
			get { return this.GetPropertyValue<string>("logistiekTitle"); }
		}

		///<summary>
		/// Pers Text: Text voor pers Item
		///</summary>
		[ImplementPropertyType("persText")]
		public IHtmlString PersText
		{
			get { return this.GetPropertyValue<IHtmlString>("persText"); }
		}

		///<summary>
		/// Pers Title: Title voor pers item
		///</summary>
		[ImplementPropertyType("persTitle")]
		public string PersTitle
		{
			get { return this.GetPropertyValue<string>("persTitle"); }
		}

		///<summary>
		/// Banner author: naam van author van de quote in de zwarte balk
		///</summary>
		[ImplementPropertyType("bannerAuthor")]
		public string BannerAuthor
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetBannerAuthor(this); }
		}

		///<summary>
		/// Banner Image: Banner foto
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetBannerImage(this); }
		}

		///<summary>
		/// WitteBox: tekst om in de witte box op de banner te plaatsen
		///</summary>
		[ImplementPropertyType("witteBox")]
		public string WitteBox
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetWitteBox(this); }
		}

		///<summary>
		/// ZwarteText: text in zwarte box op banner
		///</summary>
		[ImplementPropertyType("zwarteText")]
		public string ZwarteText
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetZwarteText(this); }
		}

		///<summary>
		/// Subtitle: subtitle voor de title onder de banner
		///</summary>
		[ImplementPropertyType("subtitle")]
		public IHtmlString Subtitle
		{
			get { return Umbraco.Web.PublishedContentModels.Title.GetSubtitle(this); }
		}

		///<summary>
		/// Title: title onder banner
		///</summary>
		[ImplementPropertyType("titleText")]
		public string TitleText
		{
			get { return Umbraco.Web.PublishedContentModels.Title.GetTitleText(this); }
		}
	}

	/// <summary>Portfolio</summary>
	[PublishedContentModel("portfolio")]
	public partial class Portfolio : Master, IBannerItems
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "portfolio";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Portfolio(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Portfolio, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner author: naam van author van de quote in de zwarte balk
		///</summary>
		[ImplementPropertyType("bannerAuthor")]
		public string BannerAuthor
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetBannerAuthor(this); }
		}

		///<summary>
		/// Banner Image: Banner foto
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetBannerImage(this); }
		}

		///<summary>
		/// WitteBox: tekst om in de witte box op de banner te plaatsen
		///</summary>
		[ImplementPropertyType("witteBox")]
		public string WitteBox
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetWitteBox(this); }
		}

		///<summary>
		/// ZwarteText: text in zwarte box op banner
		///</summary>
		[ImplementPropertyType("zwarteText")]
		public string ZwarteText
		{
			get { return Umbraco.Web.PublishedContentModels.BannerItems.GetZwarteText(this); }
		}
	}

	/// <summary>PortfolioDetail</summary>
	[PublishedContentModel("portfolioDetail")]
	public partial class PortfolioDetail : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "portfolioDetail";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PortfolioDetail(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PortfolioDetail, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	// Mixin content Type 1130 with alias "bannerItems"
	/// <summary>Banner Items</summary>
	public partial interface IBannerItems : IPublishedContent
	{
		/// <summary>Banner author</summary>
		string BannerAuthor { get; }

		/// <summary>Banner Image</summary>
		IPublishedContent BannerImage { get; }

		/// <summary>WitteBox</summary>
		string WitteBox { get; }

		/// <summary>ZwarteText</summary>
		string ZwarteText { get; }
	}

	/// <summary>Banner Items</summary>
	[PublishedContentModel("bannerItems")]
	public partial class BannerItems : PublishedContentModel, IBannerItems
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "bannerItems";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BannerItems(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BannerItems, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner author: naam van author van de quote in de zwarte balk
		///</summary>
		[ImplementPropertyType("bannerAuthor")]
		public string BannerAuthor
		{
			get { return GetBannerAuthor(this); }
		}

		/// <summary>Static getter for Banner author</summary>
		public static string GetBannerAuthor(IBannerItems that) { return that.GetPropertyValue<string>("bannerAuthor"); }

		///<summary>
		/// Banner Image: Banner foto
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return GetBannerImage(this); }
		}

		/// <summary>Static getter for Banner Image</summary>
		public static IPublishedContent GetBannerImage(IBannerItems that) { return that.GetPropertyValue<IPublishedContent>("bannerImage"); }

		///<summary>
		/// WitteBox: tekst om in de witte box op de banner te plaatsen
		///</summary>
		[ImplementPropertyType("witteBox")]
		public string WitteBox
		{
			get { return GetWitteBox(this); }
		}

		/// <summary>Static getter for WitteBox</summary>
		public static string GetWitteBox(IBannerItems that) { return that.GetPropertyValue<string>("witteBox"); }

		///<summary>
		/// ZwarteText: text in zwarte box op banner
		///</summary>
		[ImplementPropertyType("zwarteText")]
		public string ZwarteText
		{
			get { return GetZwarteText(this); }
		}

		/// <summary>Static getter for ZwarteText</summary>
		public static string GetZwarteText(IBannerItems that) { return that.GetPropertyValue<string>("zwarteText"); }
	}

	// Mixin content Type 1132 with alias "title"
	/// <summary>Title</summary>
	public partial interface ITitle : IPublishedContent
	{
		/// <summary>Subtitle</summary>
		IHtmlString Subtitle { get; }

		/// <summary>Title</summary>
		string TitleText { get; }
	}

	/// <summary>Title</summary>
	[PublishedContentModel("title")]
	public partial class Title : PublishedContentModel, ITitle
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "title";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Title(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Title, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Subtitle: subtitle voor de title onder de banner
		///</summary>
		[ImplementPropertyType("subtitle")]
		public IHtmlString Subtitle
		{
			get { return GetSubtitle(this); }
		}

		/// <summary>Static getter for Subtitle</summary>
		public static IHtmlString GetSubtitle(ITitle that) { return that.GetPropertyValue<IHtmlString>("subtitle"); }

		///<summary>
		/// Title: title onder banner
		///</summary>
		[ImplementPropertyType("titleText")]
		public string TitleText
		{
			get { return GetTitleText(this); }
		}

		/// <summary>Static getter for Title</summary>
		public static string GetTitleText(ITitle that) { return that.GetPropertyValue<string>("titleText"); }
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
