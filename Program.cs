using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Test_SectionC
{
    internal class Program
    {
        public static string name;
        public static List<string> items = new List<string>();
        

        static void Main(string[] args)
        {
            NumberPattern();
            GradingSystem();
            Console.WriteLine("Welcome to your shopping list" + "\n" + "Enter your name: ");
            name = Console.ReadLine();
            Console.Clear();
            Menu();


        }

        static void Menu()
        {
            Console.WriteLine(name + " Please choose from the following menu " + "\n" + "1. Add item " + "\n" + "2. Remove item " + "\n" + "3. View item " + "\n" + "4. Exit ");
            Console.Write("Enter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                AddItem();
            }
            if (choice == 2)
            {
                RemoveItem();
            }
            if (choice == 3)
            {
                ViewItems();
            }
            else if (choice == 4)
            {
                Environment.Exit(0);
            }
        }

        static void AddItem()
        {

            Console.Write(name + "Enter item to add : ");
            string item = Console.ReadLine();
            items.Add(item);

                for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("Item added succesfully!!");

                ViewItems();

                }
                
            


            /*  if (items.Count > 0)
              {
                  Console.WriteLine("Item added!!");
              }
              else if(items.Count <1) 
              {
                  Console.WriteLine("Item not added");
              }
            */


        }

        static void RemoveItem()
        {
            Console.WriteLine("Which item do you want to remove from the following ");
            ViewItems();
            string answer = Console.ReadLine();
            items.Remove(answer);
            ViewItems();
        }

        static void ViewItems()
        {
            Console.WriteLine("You have the following items :");

            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        static void GradingSystem()
        {
            int[] marks = new int[5];

            Console.Write("Enter student name1 ");
            string name = Console.ReadLine();

            Console.WriteLine("student mark");
            double mark = double.Parse(Console.ReadLine());
            double avg = mark / 100;

            // marks.Insert(mark);
            if (mark > 90 && mark <= 100)
            {
                Console.WriteLine("A");
                Console.WriteLine("avg : " + avg);
            }
            else if (mark >= 80 && mark <= 89)
            {
                Console.WriteLine("B");
                Console.WriteLine("avg : " + avg);

            }
            else if (mark >= 70 && mark <= 79)
            {
                Console.WriteLine("C");
                Console.WriteLine("avg : " + avg);

            }
            else if (mark >= 60 && mark <= 69)
            {
                Console.WriteLine("D");
                Console.WriteLine("avg : " + avg);

            }
            if (mark < 60)
            {
                Console.WriteLine("fail");
            }
        }

        static void NumberPattern()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }


    }
}
