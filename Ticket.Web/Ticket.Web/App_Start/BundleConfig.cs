﻿using System.Web;
using System.Web.Optimization;

namespace Ticket.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));



            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/jquery-1.9.1.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/metisMenu.js",
                        "~/Scripts/raphael-min.js",
                    //    "~/Scripts/morris.min.js",
                     //   "~/Scripts/morris-data.js",
                        "~/Scripts/sb-admin-2.js"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/login_css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/metisMenu.css",
                        "~/Content/sb-admin-2.css",
                        "~/Content/font-awesome"
                        ));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
            "~/Content/bootstrap.css",
            "~/Content/metisMenu.css",
            "~/Content/timeline.css",
             "~/Content/sb-admin-2.css",
            "~/Content/morris.css",
            "~/Content/font-awesome.css"
            ));

        }
    }
}