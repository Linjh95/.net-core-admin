using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Linjh.Models
{
    public class Menu : Entity
    {
        //菜单关系
        [DefaultValue(0)]
        public int Pid { get; set; }
        //菜单名称
        [DefaultValue("")]
        public string Name { get; set; }
        //图标
        [DefaultValue("")]
        public string Icon { get; set; }
        //菜单对应的权限
        [DefaultValue("")]
        public string Slug { get; set; }
        //菜单链接地址
        [DefaultValue("")]
        public string Url { get; set; }
        //菜单高亮地址
        [DefaultValue("")]
        public string Active { get; set; }
        //描述
        [DefaultValue("")]
        public string Description { get; set; }
        //排序
        [DefaultValue(0)]
        public int Sort { get; set; }
    }
}
