﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Animal
{
   
    class Person
    {
        public double height;
        public int age;
        public string name;

        public void Sayhi()
        {
            Console.WriteLine("你好啊我叫" + name);
        }

        public bool IsAdult()
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Add(int num1, int num2, string qq)
        {
            return num1 + num2;
        }

    }
}



