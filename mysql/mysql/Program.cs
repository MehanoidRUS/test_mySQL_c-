﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlData client =new SqlData();
            client.AddData();
            client.ReadData();
            Console.ReadKey();
        }
    }
}
