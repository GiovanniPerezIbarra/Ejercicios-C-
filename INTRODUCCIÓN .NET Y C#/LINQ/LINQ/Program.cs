﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperacionesLINQ operaciones = new OperacionesLINQ();
            operaciones.Consultas();
            Console.ReadLine();
        }
    }
}
