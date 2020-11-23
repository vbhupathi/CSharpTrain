using System;
using System.Collections.Generic;
using Helpers;
using LinqTrain;

namespace CSharpTrain
{
    partial class Program
    {
        public static Pet[] GetCats()
        {
            Pet[] cats = { new Pet { Name="Barley", Age=8 },
                        new Pet { Name="Boots", Age=4 },
                        new Pet { Name="Whiskers", Age=1 } };
            return cats;
        }

        public static Pet[] GetDogs()
        {
            Pet[] dogs = { new Pet { Name="Bounder", Age=3 },
                        new Pet { Name="Snoopy", Age=14 },
                        new Pet { Name="Fido", Age=9 } };
            return dogs;
        }
    
        static void Main(string[] args)
        {
            //Set Operations
            myDistinctOfIntegerSequence();
            myDistinctOfSpecifiedIEqualityComparerValues();
            myExceptToCompareTwoSequencesOfNumbers();

            //Concatenation Operation
            myConcatExample();
            //Max Operations
            MyMaxOfASequenceOfInt32();
            MyMaxOfASequenceOfNUllableDouble();
            //Average Operations
            MyAverageOfSequenceOfSingleValues();
            MyAverageOfSequenceOfNullableInt64Values();
            MyAverageOfASequenceOfInt32();

            //Aggregate Operations
            MyAggregateOperation();
            MyAggregateOperationWithSeedandResultSelector();
            MyAggregateOperationWithSeedAndFunc();
            
            //Count Operations
            MyCountWithSource();
            MyCountWithPredicate();

            MyLongCountWithSource();
            MyLongCountWithPredicate();

            //Filtering Data Operations
            MyOfTypeFilter();
            MyWhereFilter();
            MyWhereFilterWithIndex();
            
            //Projection Operations
            MySelectProjection();
            MySelectProjectionWithIndex();

            MySelectManyProjectionWithTCollectionSelector();
            MySelectManyProjectionWithTCollectionSelectorAndIndex();
            MySelectManyProjectionWithSelector();
            MySelectManyProjectionWithSelectorIndex(); 
        }

        private static void myExceptToCompareTwoSequencesOfNumbers()
        {
            double[] numbers1 = { 2.0, 2.0, 2.1, 2.2, 2.3, 2.3, 2.4, 2.5 };
            double[] numbers2 = { 2.2 };

            IEnumerable<double> onlyInFirstSet = numbers1.myExcept(numbers2);

            foreach (double number in onlyInFirstSet)
                Console.WriteLine(number);

            /*
             This code produces the following output:

             2
             2.1
             2.3
             2.4
             2.5
            */
        }
        private static void myDistinctOfSpecifiedIEqualityComparerValues()
        {
            Product[] products = { new Product { Name = "apple", Code = 9 },
                       new Product { Name = "orange", Code = 4 },
                       new Product { Name = "apple", Code = 9 },
                       new Product { Name = "lemon", Code = 12 } };

            //Exclude duplicates.

            IEnumerable<Product> noduplicates =
                products.myDistinct();

            foreach (var product in noduplicates)
                Console.WriteLine(product.Name + " " + product.Code);

            /*
                This code produces the following output:
                apple 9
                orange 4
                lemon 12
            */
        }

        private static void myDistinctOfIntegerSequence()
        {
            List<int> ages = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55 };

            IEnumerable<int> distinctAges = ages.myDistinct();

            Console.WriteLine("Distinct ages:");

            foreach (int age in distinctAges)
            {
                Console.WriteLine(age);
            }

            /*
             This code produces the following output:

             Distinct ages:
             21
             46
             55
             17
            */
        }
       
        
        private static void myConcatExample()
        {
            Pet[] cats = GetCats();
            Pet[] dogs = GetDogs();

            var query = cats.mySelect(cat => cat.Name).myConcat(dogs.mySelect(dog => dog.Name));

            foreach (string name in query)
            {
                Console.WriteLine(name);
            }

            // This code produces the following output:
            //
            // Barley
            // Boots
            // Whiskers
            // Bounder
            // Snoopy
            // Fido
        }

        private static void MyOfTypeFilter()
        {
            // Apply OfType() to the ArrayList.
            System.Collections.ArrayList fruits = new System.Collections.ArrayList(4){"Mango","Orange","Apple","3.0","Banana"};
            IEnumerable<string> query1 = fruits.myOfType<string>();

            Console.WriteLine("Elements of type 'string' are:");
            foreach (string fruit in query1)
            {
                Console.WriteLine(fruit);
            }

            // The following query shows that the standard query operators such as
            // Where() can be applied to the ArrayList type after calling OfType().
            IEnumerable<string> query2 =
                fruits.myOfType<string>().myWhere(fruit => fruit.ToLower().Contains("n"));

            Console.WriteLine("\nThe following strings contain 'n':");
            foreach (string fruit in query2)
            {
                Console.WriteLine(fruit);
            }

            // This code produces the following output:
            //
            // Elements of type 'string' are:
            // Mango
            // Orange
            // Apple
            // Banana
            //
            // The following strings contain 'n':
            // Mango
            // Orange
            // Banana

        }

        private static void MyMaxOfASequenceOfNUllableDouble()
        {
            double?[] doubles = { null, 1.5E+104, 9E+103, -2E+103 };

            double? max = doubles.myMax();

            Console.WriteLine($"The largest number is {max}.");

            /*
             This code produces the following output:

             The largest number is 1.5E+104.
            */
        }

        private static void MyMaxOfASequenceOfInt32()
        {
            List<int> nums = new List<int>{ 9, 12, 15, 18, 20, 3, 45};
            var maxNum = nums.myMax();
            Console.WriteLine($"The Maximum number from the given numbers is: {maxNum}");
        }
        private static void  MyAverageOfASequenceOfInt32()
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            double average = fruits.myAverage(s => s.Length);

            Console.WriteLine("The average string length is {0}.", average);

            // This code produces the following output:
            //
            // The average string length is 6.5.
        } 

        private static void  MyAverageOfSequenceOfNullableInt64Values()
        {
            long?[] longs = { null, 10007L, 37L, 399846234235L };

            double? average = longs.myAverage();

            Console.WriteLine($"The average is {average}." );
        }

        private static void MyAverageOfSequenceOfSingleValues()
        {
            List<float> grades = new List<float> { 78, 92, 100, 37, 81 };

            var average = grades.myAverage();

            Console.WriteLine($"The average grade is {average}.");

            // This code produces the following output:
            //
            // The average grade is 77.6.
        }
        private static void MyLongCountWithSource()
        {
            string[] fruits = { "apple", "banana", "mango",
                      "orange", "passionfruit", "grape" };

            long count = fruits.myLongCount();

            Console.WriteLine($"There are {count} fruits in the collection.");

        }

        private static void MyLongCountWithPredicate()
        {
            Pet[] pets = { new Pet { Name="Barley", Age=8 },
                   new Pet { Name="Boots", Age=4 },
                   new Pet { Name="Whiskers", Age=1 } };

            const int Age = 3;

            long count = pets.myLongCount(pet => pet.Age > Age);

            Console.WriteLine($"There are {count} animals over age {Age}.");
        }

        private static void MyCountWithSource()
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            try
            {
                int numberOfFruits = fruits.myCount();
                Console.WriteLine(
                    "There are {0} fruits in the collection.",
                    numberOfFruits);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The count is too large to store as an Int32.");
                Console.WriteLine("Try using the LongCount() method instead.");
            }
            
        }        
        private static void MyCountWithPredicate()
        {
        
            Pet[] pets = { new Pet { Name="Barley", Vaccinated=true },
                   new Pet { Name="Boots", Vaccinated=false },
                   new Pet { Name="Whiskers", Vaccinated=false } };

            try
            {
                int numberUnvaccinated = pets.myCount(p => p.Vaccinated == false);
                Console.WriteLine($"There are {numberUnvaccinated} unvaccinated animals.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The count is too large to store as an Int32.");
                Console.WriteLine("Try using the LongCount() method instead.");
            }        
        
        }

        private static void MyAggregateOperationWithSeedandResultSelector()
        {
            string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };
            
            Console.WriteLine($"\nThis output is from myAggregateOperationWithSeedandResultSelector:");


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
            Console.WriteLine("Done!!!\n");
        }

        private static void MyAggregateOperationWithSeedAndFunc()
        {
            int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };

            Console.WriteLine($"\nThis output is from myAggregateOperationWithSeedAndFunc:");


            // Count the even numbers in the array, using a seed value of 0.
            int numEven = ints.myAggregate(0, (total, next) =>
                                                next % 2 == 0 ? total + 1 : total);

            Console.WriteLine($"The number of even integers are: {numEven}");
            Console.WriteLine("Done!!!\n");

        }

        private static void MyAggregateOperation()
        {
            string sentence = "the quick brown fox jumps over the lazy dog";

            // Split the string into individual words.
            string[] words = sentence.Split(' ');

            // Prepend each word to the beginning of the
            // new sentence to reverse the word order.
            Console.WriteLine($"\nThis output is from myAggregateOperation:");

            string reversed = words.myAggregate((workingSentence, next) =>
                                                  next + " " + workingSentence);

            Console.WriteLine($"The reversed sentence is: \n{reversed}");
            Console.WriteLine("Done!!!\n");
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
