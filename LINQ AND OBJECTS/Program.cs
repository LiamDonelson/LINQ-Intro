using System.Globalization;
using System.Xml.Linq;

namespace LINQ_AND_OBJECTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            

            // prints even numbers
            List<int> evenNums = nums.Where(num => num%2 ==0).ToList();
            PrintList(evenNums);


            // prints numbers under 50
            List<int> numsUnder50 = nums.Where(num => num < 50).ToList();
            PrintList(numsUnder50);

            // prints numbers between 10 and 100
            List<int> numsBetween10and100 = nums.Where(num => num <= 10 && num < 100).ToList();
            PrintList(numsBetween10and100);

            // prints numbers between 100k and 999k
            List<int> numsBetween100000and999999 = nums.Where(num => num > 100000 && num <= 999999).ToList();
            PrintList(numsBetween100000and999999);



            // prints numbers from greatest to least
            List<int> numbsLeastToGreatest = nums.OrderByDescending(num=>num).ToList();
            PrintList(numbsLeastToGreatest);


            // prints even numbers
            int EvenNumbers = nums.Count(n => n % 2 == 0);
            Console.WriteLine(EvenNumbers);

            // prints the max number
            int maxNumbers=nums.Max();
            Console.WriteLine(maxNumbers);

            // prints the min number
            int minNumbers=nums.Min();
            Console.WriteLine(minNumbers);

            // prince the max number thats less than 10000
             int maxNumberParams = nums.Where(num => num<10000).Max();
            Console.WriteLine(maxNumberParams);


            // test thingy
            Students stu = new Students("Kaden",18);

            Console.WriteLine(stu.Name + stu.Age);

            // adding all of the data to the object
            // Objects are useable as list and array types
            List<Students> students = new List<Students>();
            students.Add(new Students("Jimmy", 13));
            students.Add(new Students("Hannah Baker", 21));
            students.Add(new Students("Justin", 30));
            students.Add(new Students("Sarah", 53));
            students.Add(new Students("Hannibal", 15));
            students.Add(new Students("Phillip", 16));
            students.Add(new Students("Maria", 63));
            students.Add(new Students("Abe", 33));
            students.Add(new Students("Curtis", 10));



            List<Students> studentsOver21 = students.Where(c => c.Age > 21).ToList();
            PrintNames(studentsOver21);


            int oldestStudent = students.Max(c => c.Age);
            Students OldestStudentName = students.Where(s => s.Age == oldestStudent).ToList().First();

            Console.WriteLine($"The oldest Student is: {OldestStudentName.Name} who is {OldestStudentName.Age} years old ");


            int youngestStudent = students.Min(c => c.Age);
            Students youngestStudentName = students.Where(s => s.Age == youngestStudent).First();

            Console.WriteLine($"The youngest student is: {youngestStudentName.Name} who is {youngestStudentName.Age} years old ");





            List<Students> oldestStudentUnder25 = students.Where(s => s.Age <= 25).ToList();
            int oldestStudentUnder25Age = oldestStudentUnder25.Max(c => c.Age);
            Students oldestStudentUnder25Name = oldestStudentUnder25.Where(s => s.Age == oldestStudentUnder25Age).First();





            Console.WriteLine($"The youngest student that is under the age of 25 is {oldestStudentUnder25Name.Name} and they are {oldestStudentUnder25Age} years old");

            List<Students> over21 = students.Where(s => s.Age > 21 && s.Age % 2 ==0).ToList();
            Console.WriteLine("Students over the age 21 and have an even numbered age are:");
            PrintNames(over21);

            List<Students> teenagers = students.Where(s => s.Age >= 13 && s.Age <= 19).ToList();
            Console.WriteLine("Students that are teenagers are:");
            PrintNames(teenagers);


            string vowels = "AEIOU";
            List<Students> studentNamesBeginWithVowel = new List<Students>();

            List<Students> studentVowelNames = students.Where(s => vowels.Contains(s.Name[0])).ToList();
            Console.WriteLine("Students whose names begins with a vowel.");
            PrintNames(studentVowelNames);




        }

        public static void PrintNames(List<Students> students)
        {
            for (int i = 0; i<students.Count; i++)
            {
                Students stu = students[i];
                Console.WriteLine();
                Console.WriteLine($"Name:{stu.Name} Age : {stu.Age}");
            }
        }






        public static void PrintList(List<int> input)
        {
            for (int i=0; i<input.Count; i++)
            {
                int num = input[i];
                Console.WriteLine($"{i}: {num}");
            }
        }
    }
}

//For students: 
//Find all students age of 21 and over (aka US drinking age)  *
//Find the oldest student *
//Find the youngest student *
//Find the oldest student under the age of 25 *
//Find all students over 21 and with even ages*
//Find all teenage students (13 to 19 inclusive)* 
//Find all students whose name starts with a vowel
