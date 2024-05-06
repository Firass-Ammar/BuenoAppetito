using BuonAppetito.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuonAppetito.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }

        }
    }

