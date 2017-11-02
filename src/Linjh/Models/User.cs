using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linjh.Models
{
    public class User
    {
        //用户ID
        public int UserId { get; set; }
        //用户名
        public string UserName { get; set; }
        //姓名
        public string Name { get; set; }
        //邮箱
        public string Email { get; set; }
        //手机号码
        public string Mobile { get; set; }
        //备注
        public string Remarks { get; set; }
        //创建人
        public Guid CreateUserId { get; set; }
        //创建时间
        public DateTime? CreateTime { get; set; }
        //上次登录时间
        public DateTime LastLoginTime { get; set; }
        //登录次数
        public int LoginTimes { get; set; }
        //部门ID
        public Guid DepartmentId { get; set; }
        //是否已删除
        public int IsDeleted { get; set; }
        //所属部门实体
        public virtual Department Department { get; set; }
        //创建人实体
        public virtual User CreateUser { get; set; }
        //角色集合
        public virtual ICollection<Role> Roles { get; set; }
    }
}
