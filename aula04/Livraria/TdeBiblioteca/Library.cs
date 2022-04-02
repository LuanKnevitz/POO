using System;
using System.Collections.Generic;

namespace Livraria.TdeBiblioteca
{
    public class Library
    {
        private List<Book> library=new List<Book>();

        public void addBook(Book book){
            library.Add(book);
        }

        public void showBooks(){
            library.ForEach(book=>Console.WriteLine(book.toString()));
        }

        public Book findBook(Book book){
           return library.Find(b=>b==book);
        }

        public void rentBook(Book book, User user){
            user.setBook(findBook(book));
            library.Remove(book);
            Console.WriteLine("Book rented by: "+user.getName()+", book name: "+book.getTitle());
        }
    }
}