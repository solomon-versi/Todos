﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Todos.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}