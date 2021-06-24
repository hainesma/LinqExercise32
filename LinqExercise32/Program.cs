using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> nums = new List<int>() { 10, 2330, 112233, 10, 949, 3764, 2942 };

            // 1) Find the minimum value
            int result = nums.Min();

            // 2) Find the maximum value
            int result2 = nums.Max();

            // 3) Find the maximum value less than 10000


            // 4) Find all the values between 10 and 100
            List<int> smallNums = nums.Where(x => x >= 10 && x <= 100).ToList();

            // 5) Find all the values between 100000 and 9999999
            List<int> bigNums = nums.Where(x => x >= 100000 && x <= 999999).ToList();

            // 6) Count all the even numbers
            List<int> evenNums = nums.Where(x => x % 2 == 0).ToList();


            double result3 = nums.Average();

            List<Student> students = new List<Student>();

            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
