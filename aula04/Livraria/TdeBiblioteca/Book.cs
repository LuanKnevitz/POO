namespace Livraria.TdeBiblioteca
{
    public class Book
    {
        private string title { get; set; }
        private string author {get;set;}
        private int numberOfPages {get; set;}

        public Book(string title, string author, int numberOfPages )
        {
            this.title=title;
            this.author=author;
            this.numberOfPages=numberOfPages;
        }

        public string toString(){
            return "Titulo: "+this.title+"\n Autor: "+author+"\n número de páginas: "+numberOfPages;
        }

        public string getTitle(){
            return this.title;
        }
    
    }
}