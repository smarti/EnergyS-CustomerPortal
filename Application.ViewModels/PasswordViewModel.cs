﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class PasswordViewModel
    {
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
    }
}
