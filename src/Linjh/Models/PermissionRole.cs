using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linjh.Models
{
    public class PermissionRole : Entity
    {
        public int RoleId { get; set; }

        public int PermissionId { get; set; }
    }
}
