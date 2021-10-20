using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public List<double> grades;
        //public List<double> grades = new List<double>();
        private string name;

        public Book() {
            grades = new List<double>();
        }

        public Book(string name) {
            grades = new List<double>(0);
            this.name = name;
        }

        public void Addgrade(double grad) {
            if(grad >= 0 && grad <= 100) {
                grades.Add(grad);
            }
        }
        public static String getSalutations(string username)
        {
            return "Sup" + username;
        }


        public void ShowStats()
        {
            double x=3.142, y=22.001; 
            var ans=0.00;
            ans = y/x;
            double result = 0.00;

            double[] num = new double[] {13.51, 6.43, 8.25, 90.0};
            foreach(double n in num) {
                result += n;
                System.Console.WriteLine($"The sum is {result}");
            }
            Console.WriteLine($"the value of the double {ans} \n");           

            //List 
            List<double> grades = new List<double>() {13.51, 6.43, 8.25, 90.0};
            grades.Add(90.99);

            double highGrade = double.MinValue;
            double lowGrade = 0.00;            

            foreach(double grade in grades) {
                if (grade > highGrade) {
                    result += grade;
                    lowGrade = Math.Max(grade, highGrade);
                }
            }

            result /= grades.Count;
            System.Console.WriteLine($"The average range is {result:N2}");
            System.Console.WriteLine($"The average range is {result:N2}");


        }
    }
}