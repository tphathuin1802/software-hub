﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    [Serializable]
    public class Customer
    {
        public string Ma {  get; set; } 
        public string Ten { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
