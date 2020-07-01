using System;

namespace _11_Referência__Classe_
{
    class Program
    {
        static void Main(string[] args)
        {
        //A classe Object pode armazenar qualquer tipo de dado (incluindo classes)
            Book bk = new Book();
            Object obk = bk;

            Diary dy = new Diary(38);
            Object ody = dy;

            int i = 9;
            Object oi = i;


            Book b = new Book();
            Diary d = new Diary(38);
            Random r = new Random();

            Object[] objects = { b, d, r, i };

            foreach (Object obj in objects)
                Console.WriteLine(obj.GetType());

            Book bbk = new Book("Ta-Nehisi Coates", "Between the World and Me");
            Console.WriteLine(bbk.ToString());

            Diary ddy = new Diary();
            Console.WriteLine(ddy);

            bool bb = true;
            Diary dd = new Diary();
            Console.WriteLine(bb);
            Console.WriteLine(dd);
            Console.WriteLine(bb);
            Console.WriteLine(bb.ToString());
        }
    }

    interface IFlippable
    {
        int CurrentPage { get; set; }
        void Flip();
    }

    class Book
    {
        public string Author { get; private set; }
        public string Title { get; private set; }

        public Book(string author = "Unknown", string title = "Untitled")
        {
            Author = author;
            Title = title;
        }

        public virtual string Stringify()
        { return "This is a Book object!"; }

        public override string ToString()
        {   return $"This Book is {Title}, by {Author}.";   }
    }

    class Diary : Book, IFlippable
    {
        public int CurrentPage { get; set; }

        public Diary(int page = 0) : base()
        { CurrentPage = page; }

        public Diary(int page, string author, string title) : base(author, title)
        { CurrentPage = page; }

        public void Flip()
        { CurrentPage++; }

        public string SpillSecret()
        { return "OMG kerry loves kris <3"; }

        public override string Stringify()
        { return "This is a Diary object!"; }
    }
}
