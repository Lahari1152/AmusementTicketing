﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class User
    {
       // public int UserId { get; set; }

       // [Required]
       // public string Name { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

       
        //public string Email { get; set; }

        
        //public long Phone { get; set; }
    }
}
