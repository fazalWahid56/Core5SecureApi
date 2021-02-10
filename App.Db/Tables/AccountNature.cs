﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.Db.Tables
{
    public class AccountNature:BaseEntity
    {
        [Key]
        public int AccountNatureId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description {get; set;}
        public List<ChartOfAccount> ChartOfAccount { get; set; }
    }
}
