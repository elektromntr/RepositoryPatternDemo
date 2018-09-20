using System.Web.Optimization;

public class BundleConfig
{
    public static void RegisterBundles(BundleCollection bundles)
    {
        bundles.Add(new ScriptBundle("~/Script/js").Include("~/Scripts/bootstrap.js"));
        bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css"));

        BundleTable.EnableOptimizations = true;
    }
}