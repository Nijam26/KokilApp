﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KokilApp.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string? PropfilePictureUrl { get; set; }
        //Navigation Property
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
