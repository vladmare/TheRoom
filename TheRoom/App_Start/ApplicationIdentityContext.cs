using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheRoom.App_Start
{
  using System;
  using AspNet.Identity.MongoDB;
  using MongoDB.Driver;

  public class ApplicationIdentityContext : IdentityContext, IDisposable
  {
    public ApplicationIdentityContext(MongoCollection users, MongoCollection roles)
      : base(users, roles)
    {
    }

    public static ApplicationIdentityContext Create()
    {
      // todo add settings where appropriate to switch server & database in your own application
      var client = new MongoClient("mongodb://removed:removed@ds029640.mongolab.com:29640/theroom");
      var database = client.GetServer().GetDatabase("theroom");
      var users = database.GetCollection<IdentityUser>("users");
      var roles = database.GetCollection<IdentityRole>("roles");
      return new ApplicationIdentityContext(users, roles);
    }

    public void Dispose()
    {
    }
  }
}