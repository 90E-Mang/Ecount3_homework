﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCafeManager
{
    class User : Person
    {
        public User(string name, string email, string pw)
        {
            this.name = name;
            this.email = email;
            this.pw = pw;
        }
    }
}