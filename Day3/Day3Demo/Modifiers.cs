using Day3Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demo
{
      public class myClass
    {
        public string name= "vikram";
        private string password ="vikcam@11";
        protected string email ="vikram@gmail.com";
    }
    //public void Console.WriteLine()

    class ClassB : myClass
    {
        Console.WriteLine(name);
    }
}
