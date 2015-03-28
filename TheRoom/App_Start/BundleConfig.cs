using System.Web;
using System.Web.Optimization;

namespace TheRoom.App_Start
{
  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      // TO DO
      bundles.Add(new StyleBundle("~/Content/css").Include(
          "~/Content/bootstrap.css",
          "~/Content/site.css"));
    }
  }
}