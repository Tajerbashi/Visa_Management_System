﻿using Database.Server.Bases.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Database.Server.Models
{
    [Table("People", Schema = "Security"), Description("")]
    public class Person : BaseEntity<long>
    {
        public string Name { get; set; }
        public string Family { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Description(""), MaxLength(11), MinLength(11)]
        public string Phone { get; set; }
        public string UserName { get; set; }
        [PasswordPropertyText]
        public string Password { get; set; }
        public string Picture { get; set; }

    }
}