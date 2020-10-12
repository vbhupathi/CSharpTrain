using System;
using System.Collections.Generic;
using LinqTrain;

namespace CSharpTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWhereFilter();
            MyWhereFilterWithIndex();
            
            MySelectProjection();
            MySelectProjectionWithIndex();

            MySelectManyProjection();
        }

        private static void MySelectManyProjection()
        {
            List<List<int>> numbers = new List<List<int>>
            {
                new List<int> { 23, 45, 66 },  //0 Index
                new List<int> { 12, 88, 32 }  //1 Index
            };
            List<int> result = numbers.mySelectMany((x, i) => x.mySelect(z => z + i)).myToList();
        }

        private static void MySelectProjection()
        {
            IEnumerable<int> squares =
                            System.Linq.Enumerable.Range(1, 10).mySelect(x => x * x);

            foreach (var num in squares)
            {
                Console.WriteLine(num);
            }
        }

        private static void MySelectProjectionWithIndex()
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            var query =
                fruits.mySelect((fruit, index) =>
                                  new { index, str = fruit.Substring(0, index) });

            foreach (var obj in query)
            {
                Console.WriteLine("{0}", obj);
            }
        }

        private static void MyWhereFilterWithIndex()
        {
            int[] numbers = { 0, 30, 20, 15, 90, 85, 40, 75 };

            foreach (int number in numbers.myWhere((number, index) => number <= index * 10))
            {
                Console.WriteLine(number);
            }
        }

        private static void MyWhereFilter()
        {
            List<int> num = new List<int>() { 2, 3, 5, 8, 10, 12, 15, 22, 30 };
            Console.WriteLine($"Filtering event numbers from the list of numbers: \n");
            foreach (var item in num.myWhere(n => n % 2 == 0))
            {
                Console.WriteLine($"{item}");
            }
        }
    }

}
