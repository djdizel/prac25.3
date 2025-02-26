using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac25._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта с использованием конструктора без параметров
            CBookCard book1 = new CBookCard();
            Console.WriteLine(book1.ToString());

            // Создание объекта с использованием конструктора с параметрами
            CBookCard book2 = new CBookCard("Лев Толстой", "Война и мир", "Русский вестник", 1869, 1225, "5000 экземпляров");
            Console.WriteLine(book2.ToString());

            // Ввод данных с консоли и создание объекта
            Console.WriteLine("Введите автора:");
            string author = Console.ReadLine();
            Console.WriteLine("Введите название книги:");
            string title = Console.ReadLine();
            Console.WriteLine("Введите издательство:");
            string publishing = Console.ReadLine();
            Console.WriteLine("Введите год издания:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество страниц:");
            int numpage = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тираж:");
            string circulation = Console.ReadLine();

            CBookCard book3 = new CBookCard(author, title, publishing, year, numpage, circulation);
            Console.WriteLine(book3.ToString());

            // Установка рейтинга и комментария
            book3.Rating = 85;
            book3.Comment = "Отличная книга, рекомендую!";
            Console.WriteLine(book3.ToString());
            Console.ReadLine();
        }
    }
}