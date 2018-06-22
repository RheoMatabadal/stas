using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace NE
{
    public static class RazorExtensions
    {
        static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        public static string SizeSuffix(Int64 value)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return "0.0 bytes"; }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }

        public static string getPreferredTitle(IPublishedContent node, string preferredTitleProperty)
        {
            string title = node.Name;
            string preferredTitle = node.GetPropertyValue<string>(preferredTitleProperty);
            if (!String.IsNullOrEmpty(preferredTitle))
            {
                title = preferredTitle;
            }
            return title;
        }

        public static string getSchrijvers(List<IPublishedContent> schrijversCollection)
        {
            string schrijversString = "";

            foreach (IPublishedContent schrijver in schrijversCollection)
            {
                if (!schrijver.IsLast())
                {
                    schrijversString += "<a href='" + schrijver.Url + " class='text-muted'>" + getPreferredTitle(schrijver, "menuTitel") + "</a><span>, </span>";
                }else{
                    schrijversString += "<a href='" + schrijver.Url +"' class='text-muted'>" + getPreferredTitle(schrijver, "menuTitel") + "</a>";
                }
            }
            
            return schrijversString;
        }

        public static string getDatum(DateTime datum)
        {
            string datumString = "";
            datumString = string.Format("{0:dd MMMM yyyy}", datum);
            return datumString;
        }
    }
}