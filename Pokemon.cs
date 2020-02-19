﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace ApiTest
{
    public class Pokemon
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.ToUpper();
            }
        }
 
        public int Strength { get; set; }
 
    }
}