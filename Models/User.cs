using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TestMVC.Models
{
    public class User :IdentityUser
    {
        public string Cmt { get; set; }
        public string Phone { get; set; }
        public int Status { get; set; }
        public int RoleId { get; set; }


    
    }
}