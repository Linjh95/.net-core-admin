﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Linjh.Models
{
    public class Role : Entity
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        [DefaultValue(1)]
        public int Level { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
