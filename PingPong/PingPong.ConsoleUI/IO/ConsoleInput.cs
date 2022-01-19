﻿using PingPong.UI.IO.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.ConsoleUI.IO
{
    public class ConsoleInput : IInput<string>
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}
