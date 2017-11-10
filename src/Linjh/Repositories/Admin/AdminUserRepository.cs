using Linjh.DBcontext;
using Linjh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Linjh.Utility;

namespace Linjh.Repositories.Admin
{
    public class AdminUserRepository : Repository<AdminUser>
    {
        public AdminUserRepository(LinDbcontext dbContext) : base(dbContext)
        {

        }

        /// <summary>
        /// 检查用户是存在
        /// </summary>
        /// <param name="Name">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>存在返回用户实体，否则返回NULL</returns>
        public AdminUser CheckUser(string Name, string password)
        {
            AdminUser au = new AdminUser();
            au = _dbContext.Set<AdminUser>().FirstOrDefault(it => it.Name == Name);
            //存在该名字的用户
            if (au != null)
            {
                var de = DESEncrypt.Decrypt(au.Password);
                if (de == password)
                {
                    return au;
                }
                else
                {
                    return null;
                }
            }
            else {
                return null;
            }
        
            //string pwd = _dbContext.Set<AdminUser>().FirstOrDefault(it => it.Name == Name).Password;
            //         DESEncrypt.Decrypt(pwd);
            //return _dbContext.Set<AdminUser>().FirstOrDefault(it => it.Name == Name && it.Password == password);
        }

        /// <summary>
        /// 根据Id获取实体
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        //public AdminUser GetWithRoles(int id)
        //{
            //var user = _dbContext.Set<AdminUser>().FirstOrDefault(it => it.Id == id);
            //if (user != null)
            //{
            //    user.UserRoles = _dbContext.Set<UserRole>().Where(it => it.UserId == id).ToList();
            //}
            //return user;
        //}
    }
}
