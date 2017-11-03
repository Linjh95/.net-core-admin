using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linjh.Models
{
    public class Permission : Entity
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        public string Model { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
