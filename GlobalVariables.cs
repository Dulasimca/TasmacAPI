﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class GlobalVariables
    {
        //Dev setting
        public const string ConnectionString = "Server=127.0.0.1;Database=tncscbug;Uid=root;Pwd=54321;";

        //Live Settings 127.0.0.1 125.17.108.118
       // public const string ConnectionString = "Server=127.0.01;Database=tasmac;Uid=tasmacbugnew;Pwd=Test1234$;";

        //Mail settings
        public const string FromMailid = "tasmaccctv@gmail.com"; //"si.bontonsoftwares@gmail.com";
        public const string Password = "Bonton@1234";
        public const int Port = 587;
        public const string Host = "smtp.gmail.com";

    }
}
