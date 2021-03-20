using System.Web;
using System.Web.Optimization;

namespace printWayy_cine
{
    public class BundleConfig
    {
        // Para mais informações sobre Bundling, visite http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender com ela. Após isso, quando você estiver
            // pronto para produção, use a ferramenta de compilação em http://modernizr.com para selecionar somente os testes que você precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                        "~/Scripts/kendo/kendo.all.min.js",
                        "~/Scripts/kendo/kendo.aspnetmvc.min.js",
                        "~/Scripts/kendo/jszip.min.js",
                        "~/Scripts/kendo/cultures/kendo.culture.pt-PT.min.js",
                        "~/Scripts/kendo/cultures/kendo.culture.pt-BR.min.js",
                        "~/Scripts/kendo/pako_deflate.min.js",
                        "~/Scripts/kendo/angular.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/underscore.min.js",
                        "~/Scripts/jquery.maskedinput-1.3.1.min.js",
                        "~/Scripts/jquery.maskMoney.min.js",
                        "~/Scripts/jquery.ba-resize.min.js",
                        "~/Scripts/scripts.js",
                        "~/Scripts/_ExportExcel.min.js",
                        "~/Scripts/adminlte/adminlte.min.js",
                        "~/Scripts/menu.min.js",
                        "~/Scripts/bluebird.min.js",
                        "~/Scripts/printwayy-generic-components.min.js",
                        "~/Scripts/jquery.mask.min.js",
                        "~/Scripts/headway-manager.min.js",
                        "~/Scripts/LAB.min.js",
                        "~/Scripts/system-warning-service.min.js",
                        "~/Scripts/axios.min.js"));

            bundles.Add(new StyleBundle("~/Content/cssbundle").Include(
                        "~/Content/font.css",
                        "~/Content/layout.css",
                        "~/Content/kendo.custom.css",
                        "~/Content/jqueryui.custom.css",
                        "~/Content/content.css",
                        "~/Content/report-style.css",
                        "~/Content/kendo.common-fiori-custom.css",
                        "~/Content/kendo-fiori-custom.css",                   
                        "~/Content/kendo-metro-custom.css",
                        "~/Content/less/main.min.css"
                        ));

            bundles.Add(new StyleBundle("~/Content/themes/base/cssbundle").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css",
                        "~/Content/themes/base/jquery.ui.tooltip.css"));

            bundles.Add(new StyleBundle("~/Content/kendo/cssbundle").Include(
                        "~/Content/kendo/kendo.common.min.css",
                        "~/Content/kendo/kendo.dataviz.min.css"));

            BundleTable.EnableOptimizations = true; //habilitar bundle e minification, mesmo quando em modo debug            
        }
    }
}