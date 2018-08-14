using System.Web.Optimization;

public class BundleConfig
{
    public static void RegisterBundles(BundleCollection bundles)
    {
        bundles.Add(new ScriptBundle("~/Content/"));
        bundles.Add(new ScriptBundle("~/Script/"));

        BundleTable.EnableOptimizations = true;
    }
}