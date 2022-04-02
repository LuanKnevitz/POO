using System;

namespace Livraria.TdeBiblioteca
{
    public class User
    {
        private static int id;
        private string name;
        private Book RentedBook;

        public User(string name)
        {
            id++;
            this.name=name;
        }

        public void setBook(Book book){
            this.RentedBook=book;
        }

        public string getName(){
            return this.name;
        }

        public void returnBook(Library library){
            library.addBook(this.RentedBook);
            this.RentedBook=null;
            Console.WriteLine("The book was Returned to the library.");
        }
    }
}