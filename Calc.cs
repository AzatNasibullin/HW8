﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    internal class Calc : iCalc
    {
        public double Result { get; set; } = 0;

        private Stack<double> LastResult { get; set; } = new Stack<double>();

        public event EventHandler<EventArgs> MyEventHandler;

        private void PrintResult()
        {
            MyEventHandler?.Invoke(this, new EventArgs());
        }
        public double Devide(double x)
        {
            Result /= x;
            //PrintResult();
            LastResult.Push(Result);
            return Result;
        }
        public double Multiply(double x)
        {
            Result *= x;
            //PrintResult();
            LastResult.Push(Result);
            return Result;
        }
        public double Sub(double x)
        {
            Result -= x;
            //PrintResult();
            LastResult.Push(Result);
            return Result;
        }
        public double Sum(double x, bool dontPrint)
        {
            Result += x;
            //if (!dontPrint)
            //PrintResult();
            LastResult.Push(Result);
            return Result;
        }

        public double Divide(int x)
        {
            throw new NotImplementedException();
        }

        public void CanselLast()
        {
            if (LastResult.TryPop(out double res))
            {
                Result = res;
                Console.WriteLine("Последнее действие отменено.Результат равен:");
                PrintResult();
            }
            else
            {
                Console.WriteLine("Нельзя отменить последнее действие!");
            }
        }

        //  double iCalc.Divide(double x)
        //  {
        //      throw new NotImplementedException();
        //  }

        public double Sum(double x)
        {
            throw new NotImplementedException();
        }

        public double Sub(double x, bool dontPrint)
        {
            throw new NotImplementedException();
        }

        public void Sum(int x)
        {
            throw new NotImplementedException();
        }

        public void Sub(int x, bool dontPrint)
        {
            throw new NotImplementedException();
        }

        void iCalc.Divide(int x)
        {
            throw new NotImplementedException();
        }

        public void Multiply(int x)
        {
            throw new NotImplementedException();
        }
    }
}
