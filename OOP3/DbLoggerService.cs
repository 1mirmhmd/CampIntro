﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class DbLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
}
