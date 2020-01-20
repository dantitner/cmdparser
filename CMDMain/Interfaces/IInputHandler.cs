﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CMDMain.Interfaces
{
    interface IInputHandler
    {
        void Read();

        void Process(string message);
    }
}