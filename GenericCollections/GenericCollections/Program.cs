using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t\t|===================|" +
                             " \n\t\t\t|GENERIC COLLECTIONS|" +
                             " \n\t\t\t|*******************|\n\n");
            List();
            LinkedList();
            Queue();
            Stack();
            Dictionary();
            SortedList();
            HashSet();
        }

        public static void List()
        {
            Console.WriteLine("LIST COLLECTION\n");
            List<string> names = new List<string>(new string[] { "John", "Jess", "Jake", "Jen", "Joseph" });
            Console.WriteLine("List of names: ");
            foreach (string name in names)
            {
                Console.WriteLine($"{name}");
            }
            Console.WriteLine("\n--------------------------------------");

        }

        public static void LinkedList()
            {
                Console.WriteLine("\nLINKEDLIST COLLECTION");
                LinkedList<string> names = new LinkedList<string>();
                Console.WriteLine("List of numbers: ");

                foreach (string name in new string[5] { "John", "Jess", "Jake", "Jen", "Joseph" })
                {
                    names.AddFirst(name);
                }
                foreach (string name in names)
                {
                    Console.WriteLine($"{name}");
                }
            Console.WriteLine("\n--------------------------------------");

        }

        public static void Queue()
        {
            Console.WriteLine("\nQUEUE COLLECTION");
            Queue<string> names = new Queue<string>();

            foreach (string name in new string[5] { "John", "Jess", "Jake", "Jen", "Joseph" })
            {
                names.Enqueue(name);
                Console.WriteLine($"{name} joined the queue.");
            }

            Console.WriteLine("\nLeaving the queue...");
            while (names.Count > 0)
            {
                string name = names.Dequeue();
                Console.WriteLine($"{name} left the queue.");
            }
            Console.WriteLine("\n--------------------------------------");

        }
        public static void Stack()
        {
            Console.WriteLine("\nSTACK COLLECTION");
            Stack<string> names = new Stack<string>();
            Console.WriteLine("Pushing items onto the stack... ");

            // Filling the stack
            foreach (string name in new string[5] { "John", "Jess", "Jake", "Jen", "Joseph" })
            {
                names.Push(name);
                Console.WriteLine($"{name} has been pushed onto the stack");
            }

            // Empty the stack
            Console.WriteLine("\nPopping items from the stack...");
            while (names.Count > 0)
            {
                string name = names.Pop();
                Console.WriteLine($"{name} has been popped off the stack");
            }
            Console.WriteLine("\n--------------------------------------");
        }

        public static void Dictionary()
        {
            Console.WriteLine("\nDICTIONARY COLLECTION");
            Dictionary<string, int> ages = new Dictionary<string, int>();

            // Fill the dictionary
            ages.Add("John", 20); // using the Add method
            ages.Add("Jake", 30);
            ages["Joseph"] = 26;
            ages["Jen"] = 33; // using array notation

            Console.WriteLine("The dictionary now contains: ");
            foreach (KeyValuePair<string, int>  element in ages)
            {
                string name = element.Key;
                int age = element.Value;
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
            Console.WriteLine("\n--------------------------------------");
        }

        public static void SortedList()
        {
            Console.WriteLine("\nSORTED LIST COLLECTION");
            SortedList<string, int> names = new SortedList<string, int>();

            // Fill the SortedList
            names.Add("John", 50);
            names.Add("Jen", 18);
            names["Jake"] = 34;
            names["Jess"] = 24;
            Console.WriteLine("The SortedList contains: ");

            foreach (KeyValuePair<string, int> element in names) 
            {
                string name = element.Key;
                int age = element.Value;
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
            Console.WriteLine("\n--------------------------------------");
        }

        public static void HashSet()
        {
            Console.WriteLine("\nHASHSET COLLECTION");
            HashSet<string> basketballPlayers = new HashSet<string>(new string[] { "MJ", "Kobe", "Lebron", "Larry Bird" });
            HashSet<string> coaches = new HashSet<string>(new string[] { "Phil", "Doc", "Gregg", "Larry Bird" });

            basketballPlayers.Add("Iverson");
            coaches.Add("Pat");

            Console.WriteLine("Basketball Players: ");
            foreach (string name in basketballPlayers)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");
            Console.WriteLine("Basketball coaches: ");
            foreach (string names in coaches)
            {
                Console.WriteLine(names);
            }

            Console.WriteLine("\nCoach who was also a basketball player:");
            coaches.IntersectWith(basketballPlayers);
            foreach (string name in coaches)
            {
                Console.WriteLine(name);
            }
        }
    }
  }
 


