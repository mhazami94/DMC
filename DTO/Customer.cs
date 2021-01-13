﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string Country { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string RepeatPassword { get; set; }
    }
}
