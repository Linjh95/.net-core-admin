using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Linjh.Models;

namespace Linjh.DBcontext
{
    public class LinDbcontext : DbContext
    {
        public LinDbcontext(DbContextOptions<LinDbcontext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }

        public DbSet<AdminUser> AdminUser { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleAdminUser> RoleAdminUser { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<PermissionAdminUser> PermissionAdminUser { get; set; }
        public DbSet<PermissionRole> PermissionRole { get; set; }
        public DbSet<Menu> Menu { get; set; }
       
    }
}
