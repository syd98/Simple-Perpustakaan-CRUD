﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Perpustakaan.Models
{
    public class User
    {

        [Key]
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
