﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegFormConsoleApp
{
    interface IUsername
    {
        string Username { get; set; }

        string GenerateUserName();
    }
}