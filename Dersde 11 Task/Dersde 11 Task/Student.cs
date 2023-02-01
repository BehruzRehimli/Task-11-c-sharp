using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_11_Task
{
    internal class Student
    {
        public Student()
        {
            Count++;
            No = Count;
        }
        static int Count;
        public readonly int No;
        public string FullName;
        public byte Point;

    }
}
