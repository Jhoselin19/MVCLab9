﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLab9.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}