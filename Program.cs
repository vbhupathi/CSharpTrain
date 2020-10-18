﻿using System;
using System.Collections.Generic;
using Helpers;
using LinqTrain;

namespace CSharpTrain
{
    partial class Program
    {
        static void Main(string[] args)
        {

            //Aggregate Operations
            //myAggregateOperation();
            //myAggregateOperationWithSeedandResultSelector();
            //myAggregateOperationWithSeedAndFunc();

            /*//Filtering Data Operations
            MyWhereFilter();
            MyWhereFilterWithIndex();
            
            //Projection Operations
            MySelectProjection();
            MySelectProjectionWithIndex();

            MySelectManyProjectionWithTCollectionSelector();
            MySelectManyProjectionWithTCollectionSelectorAndIndex();
            MySelectManyProjectionWithSelector();
            MySelectManyProjectionWithSelectorIndex();*/

        }

        private static void myAggregateOperationWithSeedandResultSelector()
        {
            string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

            // Determine whether any string in the array is longer than "banana".
            string longestName =
                fruits.myAggregate("banana",
                                (longest, next) =>
                                    next.Length > longest.Length ? next : longest,
                                // Return the final result as an upper case string.
                                fruit => fruit.ToUpper());

            Console.WriteLine(
                "The fruit with the longest name is {0}.",
                longestName);

            // This code produces the following output:
            //
            // The fruit with the longest name is PASSIONFRUIT.

        }

        private static void myAggregateOperationWithSeedAndFunc()
        {
            int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };

            // Count the even numbers in the array, using a seed value of 0.
            int numEven = ints.myAggregate(0, (total, next) =>
                                                next % 2 == 0 ? total + 1 : total);

            Console.WriteLine("The number of even integers is: {0}", numEven);

            // This code produces the following output:
            //
            // The number of even integers is: 6
        }

        private static void myAggregateOperation()
        {
            string sentence = "the quick brown fox jumps over the lazy dog";

            // Split the string into individual words.
            string[] words = sentence.Split(' ');

            // Prepend each word to the beginning of the
            // new sentence to reverse the word order.
            string reversed = words.myAggregate((workingSentence, next) =>
                                                  next + " " + workingSentence);

            Console.WriteLine(reversed);

            // This code produces the following output:
            //
            // dog lazy the over jumps fox brown quick the

        }

        private static void MySelectManyProjectionWithSelectorIndex()
        {
            List<List<int>> numbers = new List<List<int>>
            {
                new List<int> { 23, 45, 66 },  //0 Index
                new List<int> { 12, 88, 32 }  //1 Index
            };
            List<int> result = numbers.mySelectMany((x, i) => x.mySelect(z => z + i)).myToList();
            Console.WriteLine($"\nThis is from MySelectManyProjectionWithSelectorIndex:");
            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Done!!!\n");
        }
        private static void MySelectManyProjectionWithTCollectionSelector()
        {
             PetOwner[] petOwners =
                { new PetOwner { Name="Higa",
                    Pets = new List<string>{ "Scruffy", "Sam" } },
                new PetOwner { Name="Ashkenazi",
                    Pets = new List<string>{ "Walker", "Sugar" } },
                new PetOwner { Name="Price",
                    Pets = new List<string>{ "Scratches", "Diesel" } },
                new PetOwner { Name="Hines",
                    Pets = new List<string>{ "Dusty" } } };

            // Project the pet owner's name and the pet's name.
            var query =
                petOwners
                .mySelectMany(petOwner => petOwner.Pets, (petOwner, petName) => new { petOwner, petName })
                .myWhere(ownerAndPet => ownerAndPet.petName.StartsWith("S"))
                .mySelect(ownerAndPet =>
                        new
                        {
                            Owner = ownerAndPet.petOwner.Name,
                            Pet = ownerAndPet.petName
                        }
                );

            Console.WriteLine($"\nThis is from MySelectManyProjectionWithTCollectionSelector:");
            foreach (var obj in query)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Done!!!\n");
        }
        
        private static void MySelectManyProjectionWithTCollectionSelectorAndIndex()
        {
             PetOwner[] petOwners =
                { new PetOwner { Name="Higa",
                    Pets = new List<string>{ "Scruffy", "Sam" } },
                new PetOwner { Name="Ashkenazi",
                    Pets = new List<string>{ "Walker", "Sugar" } },
                new PetOwner { Name="Price",
                    Pets = new List<string>{ "Scratches", "Diesel" } },
                new PetOwner { Name="Hines",
                    Pets = new List<string>{ "Dusty" } } };

            // Project the pet owner's name and the pet's name.
            var query =
                petOwners
                .mySelectMany((petOwner,i) => petOwner.Pets.mySelect(p=>p + i), (petOwner, petName) => new { petOwner, petName})
                .myWhere(ownerAndPet => ownerAndPet.petName.StartsWith("S"))
                .mySelect(ownerAndPet =>
                        new
                        {
                            Owner = ownerAndPet.petOwner.Name,
                            Pet = ownerAndPet.petName
                        }
                );

            Console.WriteLine($"\nThis is from MySelectManyProjectionWithTCollectionSelectorAndIndex:");
            foreach (var obj in query)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Done!!!\n");
        }
        
        public static void MySelectManyProjectionWithSelector()
        {
            PetOwner[] petOwners =
                { new PetOwner { Name="Higa, Sidney",
              Pets = new List<string>{ "Scruffy", "Sam" } },
          new PetOwner { Name="Ashkenazi, Ronen",
              Pets = new List<string>{ "Walker", "Sugar" } },
          new PetOwner { Name="Price, Vernette",
              Pets = new List<string>{ "Scratches", "Diesel" } } };

            // Query using mySelectMany().
            IEnumerable<string> query1 = petOwners.mySelectMany(petOwner => petOwner.Pets);

            Console.WriteLine("\nThis is from MySelectManyProjectionWithSelector:");

            // Only one foreach loop is required to iterate
            // through the results since it is a
            // one-dimensional collection.
            foreach (string pet in query1)
            {
                Console.WriteLine(pet);
            }
            System.Console.WriteLine("Done!!!\n");

            // This code shows how to use mySelect()
            // instead of mySelectMany().
            IEnumerable<List<String>> query2 =
                petOwners.mySelect(petOwner => petOwner.Pets);

            Console.WriteLine("\nUsing mySelect():");

            // Notice that two foreach loops are required to
            // iterate through the results
            // because the query returns a collection of arrays.
            foreach (List<String> petList in query2)
            {
                foreach (string pet in petList)
                {
                    Console.WriteLine(pet);
                }
            }
            Console.WriteLine("Done!!!\n");
        }

        private static void MySelectProjection()
        {
            IEnumerable<int> squares =
                            System.Linq.Enumerable.Range(1, 10).mySelect(x => x * x);
            Console.WriteLine($"\nThis is from MySelectProjection: ");

            foreach (var num in squares)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Done!!!\n");
        }

        private static void MySelectProjectionWithIndex()
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            var query =
                fruits.mySelect((fruit, index) =>
                                  new { index, str = fruit.Substring(0, index) });
            Console.WriteLine($"\nThis is from MySelectProjectionWithIndex:");
            
            foreach (var obj in query)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.WriteLine("Done!!!\n");
        }

        private static void MyWhereFilterWithIndex()
        {
            int[] numbers = { 0, 30, 20, 15, 90, 85, 40, 75 };
            Console.WriteLine("\nThis is from MyWhereFilterWithIndex:");
            foreach (int number in numbers.myWhere((number, index) => number <= index * 10))
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Done!!!\n");
        }

        private static void MyWhereFilter()
        {
            List<int> num = new List<int>() { 2, 3, 5, 8, 10, 12, 15, 22, 30 };
            Console.WriteLine($"\nThis is From MyWhereFilter: ");
            foreach (var item in num.myWhere(n => n % 2 == 0))
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Done!!!\n");
        }
    }

}
