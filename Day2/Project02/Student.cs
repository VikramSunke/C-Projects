using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project02
{
    internal class Student
    {
        private string name;
        private int english;
        private int sanskrit;
        private int mathsA;


        public string Name        
        {
            get { return name; }               
            set { name = value; }                      
        }
        public int English
        {
            get { return english; }
            set { english = value; }
        }
        public int Sanskrit
        {
            get { return sanskrit; }
            set { sanskrit = value; }
        }
        public int MathsA
        {
            get { return mathsA; }
            set { mathsA = value; }
        }

        public void StudentMarks(string name, int english, int sanskrit, int mathsA)
        {
            Name = name;
            English = english;
            Sanskrit = sanskrit;
            MathsA = mathsA;
        }
    }
        
}
