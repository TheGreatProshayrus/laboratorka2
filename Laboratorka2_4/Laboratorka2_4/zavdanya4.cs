using System;

namespace Laboratorka2_3
{
    class Book

    {
        public class Title
        {

            public string title ;

            public void Show()
            {        

                if (title == "")
                {
                    title = "Гарри Поттер";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{title}\n\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{title}\n\n");
                }
            }
        }

        public class Author
        {

            public string author;

            public void Show()
            {

                if (author == "")
                {
                    author = "Джоан Роулинг";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Книга написана автором {author}\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Книга написана автором {author}\n");
                }
            }
        }
        public class Content
        {

            public string content ;


                public void Show()
                {
                    if (content == "")
                    {
                        content = "Мальчик-маг, магия и приключения";
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Книга написана о {content}\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Книга написана о {content}\n");
                        Console.ResetColor();
                    }
                }
            }
        
    }
        /*
        public double side1; // сторона 1

        public double side2; // сторона 2

        public Rectangle(double s1, double s2) { side1 = s1; side2 = s2; }

        public void AreaCalculator()
        {
            double area = side1 * side2;
            Console.WriteLine($"Площадь = {area}");
        }

        public void PeriemetrCalculator()

        {
            double periemeter = (side1 + side2) * 2;
            Console.WriteLine($"Периметр = {periemeter}");
        }
        */

        class Program

        {   
        /*
            static string title;

            static string author;

            static string content;
        */


            static void Main(string[] args)

            {
                
                Book.Title t = new Book.Title();
                Book.Author a = new Book.Author();
                Book.Content c = new Book.Content();

                Console.WriteLine("Введите название вашей книги");
                t.title = Console.ReadLine();
                Console.WriteLine("Введите имя автора");
                a.author = Console.ReadLine();
                Console.WriteLine("Введите содержимое");
                c.content = Console.ReadLine();
                Console.WriteLine("Ваша книга готова!\n");
                t.Show();
                a.Show();
                c.Show();

                /*
                if (t1.Equals(typeof(double)) & t2.Equals(typeof(double)))
                {
                    Rectangle sqare = new Rectangle(s1, s2);

                    sqare.AreaCalculator();

                    sqare.PeriemetrCalculator();

                }
                else
                {
                    Console.WriteLine("не тот тип");

                }
                */

            }
        }
    
}
