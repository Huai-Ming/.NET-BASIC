﻿using Delegate.Basic.Practical1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Basic
{
    
    public class Client
    {
        //For Practice
        private delegate string GetAString();

        //For Practical1
        public delegate double DoubleOp(double x);

        public static void Main(string[] args)
        {
            #region For Practice
            ////Add the basic delegate appliance
            //int x = 23;
            ////GetAString firstDelegate = new GetAString(x.ToString);
            ////For the simple instantiation
            //GetAString firstDelegate = x.ToString;

            //Console.WriteLine("String is {0}", firstDelegate());
            //Console.WriteLine("String is {0}", firstDelegate.Invoke());
            #endregion

            #region For practical 1
            //DoubleOp[] operations = { MathOperations.MultiplyByTwo, MathOperations.Square };
            Func<double, double>[] operations = { MathOperations.MultiplyByTwo, MathOperations.Square };
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("Using operations [{0}]", i);
                ProcessAndDisplayNumbers(operations[i], 2.0);
                ProcessAndDisplayNumbers(operations[i], 7.94);
                ProcessAndDisplayNumbers(operations[i], 1.414);
                Console.WriteLine();
            }
            #endregion

            Console.ReadKey();
        }

        public static void ProcessAndDisplayNumbers(Func<double,double> action, double value)
        {
            double result = action(value);
            Console.WriteLine("Value is {0},reuslt of operation is {1}",value,result);
        }
    }
}