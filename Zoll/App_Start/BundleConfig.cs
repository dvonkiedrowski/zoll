using System.Web;
using System.Web.Optimization;

namespace Zoll
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/moment.min.js",
                        "~/Scripts/angular.min.js",
                        "~/Scripts/angular-messages.min.js",
                        "~/Scripts/ng-fab-form.min.js",
                        "~/Scripts/i18n/angular-locale_de-de.js",
                        "~/Scripts/angular-ui/ui-bootstrap.min.js",
                        "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js",
                        "~/Scripts/data-grid/dataGrid.min.js",
                        "~/Scripts/data-grid/dataGridUtils.min.js",
                        "~/Scripts/data-grid/loading-bar.min.js",
                        "~/Scripts/data-grid/pagination.min.js",
                        "~/Scripts/app/module.js",
                        "~/Scripts/app/controller.js",
                        "~/Scripts/app/modalController.js"));

            // Verwenden Sie die Entwicklungsversion von Modernizr zum Entwickeln und Erweitern Ihrer Kenntnisse. Wenn Sie dann
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/ngFabForm/style.css",
                      "~/Content/data-grid/fixed-header.css",
                      "~/Content/site.css"));
        }
    }
}
