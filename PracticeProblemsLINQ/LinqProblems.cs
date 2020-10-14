using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public static class LinqProblems
    {
        //Weighted project points: /10
        //Project points: /25
       
        #region Problem 1 
        //(5 points) Problem 1
        //Using LINQ, write a method that takes in a list of strings and returns all words that contain the substring “th” from a list.
        public static List<string> RunProblem1(List<string> words)
        {
            //code
            var result = words.Where(w => w.Contains("th")).ToList();
            //return
            foreach(string word in result)
            {
                Console.WriteLine(word);
            }
            return result;
        }
        #endregion

        #region Problem 2 
        //(5 points) Problem 2
        //Using LINQ, write a method that takes in a list of strings and returns a copy of the list without duplicates.
        public static List<string> RunProblem2(List<string> names)
        {
            //code
            var result = names.Distinct().ToList();
            //return
            foreach(string r in result)
            {
                Console.WriteLine(r);
            }
            return result;
        }
        #endregion

        #region Problem 3
        //(5 points) Problem 3
        //Using LINQ, write a method that takes in a list of customers and returns the lone customer who has the name of Mike. 
        public static Customer RunProblem3(List<Customer> customers)
        {
            //code
            var result = customers.FirstOrDefault(c => c.FirstName.Equals("Mike"));
            //return
            Console.WriteLine(result.FirstName);
            return result;

        }
        #endregion

        #region Problem 4
        //(5 points) Problem 4
        //Using LINQ, write a method that takes in a list of customers and returns the customer who has an id of 3. 
        //Then, update that customer's first name and last name to completely different names and return the newly updated customer from the method.
        public static Customer RunProblem4(List<Customer> customers)
        {
            //code
<<<<<<< HEAD
            var result = customers.FirstOrDefault(c => c.Id.Equals(3));
            //return
            Console.WriteLine(result.FirstName, result.Id, result.LastName);
            return result;

=======
            var result = customers.Find(c => c.Id.Equals(3));
            result.FirstName = "Jean-Luc";
            result.LastName = "Picard";

            Console.WriteLine($"{result.Id} {result.FirstName} {result.LastName}");
            //return
            return result;
>>>>>>> f6d6aa35ab6590fe52f1072d83d6a934602d81c5
        }
        #endregion

        
        }
    }
