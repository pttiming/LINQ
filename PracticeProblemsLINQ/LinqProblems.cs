using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            var result = customers.SingleOrDefault(c => c.FirstName.Equals("Mike"));
            //return
            Console.WriteLine($"{result.FirstName}");
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
            var result = customers.Find(c => c.Id.Equals(3));
            result.FirstName = "Jean Luc";
            result.LastName = "Picard";

            Console.WriteLine($"{result.Id} {result.FirstName} {result.LastName}");
            //return
            return result;
        }
        #endregion

        #region Problem 5
        //(5 points) Problem 5
                //"80,100,92,89,65",
                //"93,81,78,84,69",
                //"73,88,83,99,64",
                //"98,100,66,74,55"
        //Using LINQ, write a method that calculates the class grade average after dropping the lowest grade for each student.
        //The method should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        //Expected output: 86.125
        public static double RunProblem5(List<string> classGrades)
        {

            //code
            //Original MVP
            var grades1 = classGrades.Select(cg => cg.Split(',')).ToList().Select(cg => cg.Select(g => Convert.ToInt32(g))).ToList().Select(cg => cg.ToList().Where(g => g != cg.Min())).ToList().Select(cg => cg.Average()).ToList().Average();

            //Cleaned up Version
            var grades = classGrades.Average(cg => cg.Split(',').Select(int.Parse).OrderBy(x => x).Skip(1).Average());
            
            //return
            return grades1;
        }
        #endregion

        #region Bonus Problem 1
        //(5 points) Bonus Problem 1
        //Write a method that takes in a string of letters(i.e. “Terrill”) 
        //and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
        public static string RunBonusProblem1(string word)
        {
            //code
            //LINQ Extension Method
            var result1 = word.ToUpper().ToArray().OrderBy(l => l).GroupBy(l => l).Select(x => x.Key.ToString() + x.Count().ToString()).Aggregate((i, j) => i+j);

            //LINQ Query Method
            string result = null;
            var sorted = from l in word.ToUpper().ToArray().OrderBy(l => l)
                         group l by l into x
                         select x;
            foreach (var x in sorted)
            {
                result = result + x.Key.ToString() + x.Count().ToString();
            }
            //return
            return result1;
        }
        #endregion

    }
}
