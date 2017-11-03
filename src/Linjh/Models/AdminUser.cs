using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Linjh.Models
{
    public class AdminUser : Entity
    {
        //用户名
        [Required]
        public string UserName { get; set; }
        //姓名
        [DefaultValue("")]
        public string Name { get; set; }
        //邮箱
        [DefaultValue("")]
        public string Email { get; set; }
        //密码
        public string Password { get; set; }
        //备注
        public string Remarks { get; set; }
        //创建时间
        public DateTime? CreateTime { get; set; }
    }
}
