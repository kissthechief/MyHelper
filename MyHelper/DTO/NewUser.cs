using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyHelper.DTO
{
    public class NewUser
    {
        public string Email { get; set; }

        [StringLength(20)]
        public string Password { get; set; }
    }
}