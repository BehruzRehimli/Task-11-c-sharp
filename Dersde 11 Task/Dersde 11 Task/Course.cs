using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_11_Task
{
    internal class Course
    {
        public Course(int studentlimit)
        {
            StudentsLimit= studentlimit;
        }
        static int StudentsLimit;
        public Student[] Students= new Student[0];

        public void AddStudent(Student st) 
        {
            if (Students.Length+1<=StudentsLimit && !SeachStudNo(st.No))
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length-1] = st;
            }
        }
        public bool SeachStudNo(int no)
        {
            foreach (var item in Students)
            {
                if (item.No==no)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
