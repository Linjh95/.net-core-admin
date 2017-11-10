using Linjh.Models;
using Linjh.DBcontext;
using System;
using System.Linq;
using Linjh.Utility;

namespace Linjh.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LinDbcontext linDbcontext)
        {
            linDbcontext.Database.EnsureCreated();

            // Look for any adminuser.
            if (linDbcontext.AdminUser.Any())
            {
                return;   // DB has been seeded
            }

            var users = new AdminUser[]
            {
                new AdminUser{ Name="admin",Email="2583122953@qq.com", UserName="健华", Password = DESEncrypt.Encrypt("2017"),CreateTime=DateTime.Now },
                new AdminUser{ Name="testuser", Email="123456@163.com", UserName="测试用户" , Password = DESEncrypt.Encrypt("2017"),CreateTime=DateTime.Now }
            };

            foreach (AdminUser s in users)
            {
                linDbcontext.AdminUser.Add(s);
            }
            linDbcontext.SaveChanges();
        }
    }
}
