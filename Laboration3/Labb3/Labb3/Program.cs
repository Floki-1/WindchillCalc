using System.Reflection;

namespace Labb3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Book book1 = new("C#", 123, "Ulrika Arturson klass");
            Book bool2 = new("C#", 123, "Erin Ekman");

            Book[] myBooks = new Book[2];
            myBooks[0] = book1;
            myBooks[1] = bool2;
            for (int i = 0; i < myBooks.Length; i++)
            {
                Console.WriteLine(myBooks[i].GetBookData());
            }
        }
    }
}
