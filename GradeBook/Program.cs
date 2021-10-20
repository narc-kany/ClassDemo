using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class
            var bk = new Book();
            bk.grades.Add(78.00);
            bk.grades.Add(89.98);
            bk.grades.Add(123.88);

            var bkanme = new Book("Sivanesh");
            bkanme.grades.Add(077.88);
            bkanme.grades.Add(99.77);

            //static value
            // ctrl + k + c bulk comment
            // ctrl + k + u bulk uncomment    
            // anythging static is not a object

            bkanme.ShowStats();
        }

    }
}
