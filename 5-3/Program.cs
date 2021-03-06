﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3
{
    class Program
    {
        enum numberType{
            zero,
            odd,
            even,
            mult10,
            tooBig
        }
        static void Main(string[] args)
        {
            Console.Write("Input> ");
            int myInt = Convert.ToInt32(Console.ReadLine());
            numberType nT;
            if (myInt % 2 == 0) nT = numberType.even;
            else nT = numberType.odd;
            if (myInt % 10 == 0) nT = numberType.mult10;
            if (myInt == 0) nT = numberType.zero;
            if (myInt > 100) nT = numberType.tooBig;
            switch (nT){
                case numberType.tooBig:
                    Console.WriteLine("Too Large");
                    break;
                case numberType.zero:
                    Console.WriteLine("Equal to zero");
                    break;
                case numberType.odd:
                    Console.WriteLine("Odd");
                    break;
                case numberType.even:
                    Console.WriteLine("Even");
                    break;
                case numberType.mult10:
                    Console.WriteLine("Multiple of 10");
                    break;
                default:
                    Console.WriteLine("Don't Know");
                    break;
            }
            
        }
    }
}
