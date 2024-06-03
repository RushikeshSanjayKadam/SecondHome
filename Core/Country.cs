﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CountryTbl")]
    public class Country
    {
        [Key]
        public Int64 CountryID { get; set; }
        public string CountryName { get; set; }
    }
}
