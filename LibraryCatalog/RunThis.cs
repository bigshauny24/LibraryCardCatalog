using System;

namespace LibraryCatalog
{
    class RunProgram
    {
        private static string title;
        private static string author;
        private static string isbn;
        private static string year;
        private static string SaveToFile;

        static void Main(string[] args)
        {
            /*bool repeat = false;*/
            Console.Write("Enter filename:");
            string input = Console.ReadLine();

            CardCatalog catalog = new CardCatalog();

            bool loop = true;
            while (loop)
            {

                Console.WriteLine("1. List All Books");
                Console.WriteLine("2. Add A Book");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Save and Exit");
                string choice = Console.ReadLine();

                
               /*catalog.books.Add(Book book = new Book());--can't decalair a variable while calling a function at sametime*/



                switch (choice)
                {
                    case "1":
                        foreach (Book book in catalog.Books)
                        {
                            Console.WriteLine(book.Title);
                            Console.WriteLine(book.Author);
                            Console.WriteLine(book.Published);
                            Console.WriteLine(book.ISBN);
                            Console.WriteLine();
                        }
                        /*while (repeat == true) ;*/

                        break;
                    case "2":
                        Console.Write("title: ");
                        title = Console.ReadLine();
                        Console.Write("auth: ");
                        author = Console.ReadLine();
                        Console.Write("year: ");
                        year = Console.ReadLine();
                        Console.Write("isbn: ");
                        isbn = Console.ReadLine();
                        catalog.Books.Add(new Book(title, author, year, isbn)); /*this only worked once i declared a variable for author title year isbn*/
                        break;

                    case "3":
                        Console.Write("Search:");
                        break;


                    case "4":
                        Console.WriteLine("Save and Exit");
                        loop = false;

                        break;
                    default:
                        Console.WriteLine("Please put in a valid choice.");
                        break;
                }

               
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:\Users\ABC123\Desktop\Projects\LibraryCatalog\Data\books.txt");

                    foreach (Book book in catalog.Books)
                    {
                        string output = book.Title + ":" + book.Author + ":" + book.Published();
                        writer.WriteLine(output);
                    }

                 
                
            }         
            Console.ReadLine();



        }

        

        /*private void Search()
        {
            Console.Write("Title:");
            string title = Console.ReadLine();

            foreach(Book book in LibraryCatalog)
            {
                if(title == book.title())
                {
                    Console.WriteLine(book.ToString() + "\n");
                }
            }
        }*/
    }

}
