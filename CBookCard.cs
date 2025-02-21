using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prac25._3
{
    internal class CBookCard
    {
        /// <summary>
        /// закрытые поля
        /// </summary>
        private string author;
        private string title;
        private string publishing;
        private int year;
        private int numpage;
        private string circulation;
        private double rating;
        private string comment;
        /// <summary>
        /// инкапсуляция полей
        /// </summary>
        public string Author {
            get { return (author != "") ? author : "неизвестно"; }
            set => author = value; 
        }
        public string Title {
            get { return (title != "") ? title : "неизвестно"; }
            set => title = value;
        }
        public string Publishing {
            get { return (publishing != "") ? publishing : "неизвестно"; }
            set => publishing = value;
        }
        public int Year {
            get { return (year != 0) ? year : 0; }
            set => year = value; 
        }
        public int Numpage { 
            get { return (numpage != 0) ? numpage : 0; }
            set => numpage = value; 
        }
        public string Circulation {
            get { return (circulation != "") ? circulation : "неизвестно"; }
            set => circulation = value; 
        }
        public double Rating { 
            get { return (rating != 0) ? rating : 0; }
            set
            {
                if (value < 0)
                {
                    rating = 0;
                }
                else if (value > 100)
                {
                    rating = 100;
                }
                else
                {
                    rating = value;
                }
            }
        }
        public string Comment { 
            get { return (comment != "") ? comment : "неизвестно"; }
            set => comment = value;
        }
        /// <summary>
        /// Констурктор без параметров
        /// </summary>
        public CBookCard() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="author"></param>
        /// <param name="title"></param>
        /// <param name="publishing"></param>
        /// <param name="year"></param>
        /// <param name="numpage"></param>
        /// <param name="circulation"></param>
        public CBookCard(string author, string title, string publishing, int year, int numpage, string circulation)
        {
            Author = author;
            Title = title;
            Publishing = publishing;
            Year = year;
            Numpage = numpage;
            Circulation = circulation;
            Rating = 0;
            Comment = string.Empty;
        }

        public override string ToString()
        {
            return $"Данные о книге:{Author}\n{Title}\n{Publishing}\n{Year}\n{Numpage}\n{Circulation} \nТираж:{Rating},{Comment}";
        }
    }
}
