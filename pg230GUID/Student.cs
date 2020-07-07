using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg230GUID
{
    public class Student
    {
        //PROPERTIES
        public int id { get; set; }

        //CONSTRUCTORS 
        public Student(): this (101)
        {
        }
        public Student(int idNum)
        {
            id = idNum;
        }

    }
}
