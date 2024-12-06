using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    internal class Book
    {

        //privata fält

        //konstruktor

        //metod för att skapa isbn

        // 
       
        /// </summary>


        private string title;
        private int pages;
        private string author;
        private string isbn;
        public Book(string title, int pages, string author)
        {
            this.title = title; this.pages = pages; this.author = author;

            GenerateISBN();
        }

        private void GenerateISBN()
        {
            Random random = new Random();
            string isbnTemp = random.Next(100000000, 999999999).ToString();
            isbnTemp += $"-{random.Next(1, 9).ToString()}";
            this.isbn = isbnTemp;
        }

        public string GetBookData()
        {
            return $"Title: {title} \n Author: {author}  \n Length: {pages} \n ISBN: {isbn}";
        }


    }
    
    
}
