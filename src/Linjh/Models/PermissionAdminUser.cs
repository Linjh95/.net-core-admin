using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linjh.Models
{
    public class PermissionAdminUser : Entity
    {
        public int AdminUserId { get; set; }

        public int PermissionId { get; set; }
    }
}
