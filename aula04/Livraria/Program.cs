using System;
using Livraria.TdeBiblioteca;

namespace Livraria
{
    class Program
    {
        /*
        3 - Identifique os atributos de  um  programa  para	 controle  de
        empréstimos	de livros,	modele as classes, atributos e métodos necessários para a futura implementação.
        */
        static void Main(string[] args)
        {
            User diogo=new User("Diogo Vinícius");
            Library library=new Library();
            Book book1=new Book("livro1", "autor 1", 200);
            Book book2=new Book("livro2", "autor 2", 250);
            Book book3=new Book("livro3", "autor 3", 300);
            library.addBook(book1);
            library.addBook(book2);
            library.addBook(book3);
            library.rentBook(book3, diogo);
            library.showBooks();
            diogo.returnBook(library);
            
        }
    }
}
