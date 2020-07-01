using System;

namespace _10_Referência__Fundamentos_
{
    class Program
    {
        static void Main(string[] args)
        {

        //Caso 1
            Diary dy1 = new Diary(5);
            Diary dy2 = dy1;
            dy2.Flip();

            Console.WriteLine(dy1.CurrentPage);
            Console.WriteLine(dy2.CurrentPage);

            Console.WriteLine("\n\n");

        //Caso 2
            Book b1 = new Book();
            Book b2 = b1;
            Console.WriteLine(b1 == b2);

            Console.WriteLine("\n\n");

        //Caso 3
            Dissertation diss = new Dissertation();
            IFlippable fdiss = diss;
            Book bdiss = diss;
            fdiss.CurrentPage = 42;
            // bdiss.CurrentPage = 43;  -> erro
            // fdiss.Stringify();       -> erro
            bdiss.Stringify();
            Console.WriteLine(fdiss == bdiss);

            Console.WriteLine("\n\n");

        //Caso 4: array to reference
            Dissertation diss1 = new Dissertation(32, "Anna Knowles-Smith", "Refugees and Theatre");
            Dissertation diss2 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
            Diary dyy1 = new Diary(48, "Anne Frank", "The Diary of a Young Girl");
            Diary dyy2 = new Diary(23, "Lili Elbe", "Man into Woman");

            Book[] books = new Book[] {diss1, diss2, dyy1, dyy2};

            foreach (Book bo in books)
                Console.WriteLine(bo.Title);

            Console.WriteLine("\n\n");

        //Caso 5: Polymorphism
            Book bb1 = new Book();
            Book bb2 = new Diary();

            Console.WriteLine(bb1.Stringify());
            Console.WriteLine(bb2.Stringify());

            Console.WriteLine("\n\n");

        //Caso 6: casting
            Dissertation ddiss = new Dissertation();
            Diary dy = new Diary();

            Book bddiss = ddiss;
            Book bdy = dy;

            Console.WriteLine($"{dy} \t {bdy} \n{ddiss} \t {bddiss}");

            Console.WriteLine("\n\n");

        //Caso 7: null and assigned references
            Book b = null;
            Console.WriteLine(b);
            Console.WriteLine(b == null);

            Console.WriteLine("\n\n");

            /*  Object o;
                Console.WriteLine(o == null);       //->  error CS0165: Use of unassigned local variable 'o'
            */
        }
    }

    interface IFlippable
    {   int CurrentPage { get; set; }
        void Flip();
    }

    class Book
    {
        public string Author    { get; private set; }
        public string Title     { get; private set; }

        public Book(string author = "Unknown", string title = "Untitled")
        {   Author = author;
            Title = title;
        }

        public virtual string Stringify()
        {   return "This is a Book object!";    }
    }

    class Diary : Book, IFlippable
    {
        public int CurrentPage  { get; set; }

        public Diary(int page = 0) : base()
        {   CurrentPage = page; }

        public Diary(int page, string author, string title) : base(author, title)
        {   CurrentPage = page; }

        public void Flip()
        {   CurrentPage++;  }

        public string SpillSecret()
        {   return "OMG kerry loves kris <3";   }

        public override string Stringify()
        {   return "This is a Diary object!";   }
    }

    class Dissertation : Book, IFlippable
    {
        public int CurrentPage
        { get; set; }

        public Dissertation(int page = 0) : base()
        {   CurrentPage = page;     }

        public Dissertation(int page, string author, string title) : base(author, title)
        {   CurrentPage = page;     }

        public void Flip()
        {   CurrentPage++;      }

        public string Define()
        {   return "dissertation - a long essay on a particular subject";   }

        public override string Stringify()
        {   return "This is a Dissertation object!";    }
    }
}
