namespace Assignment2s03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            int pages = 464;

            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion

            #region 2
             bool isAvailable = true;
            if(pages>300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }
            else
            {
                Console.WriteLine("You cannot borrow this book");
            }
            #endregion

            #region 3
            string title = "Refactoring";
            switch (title)
            {
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                case "Clean Code":
                    Console.WriteLine("Great Choice!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;

            

            }
            #endregion

            #region 4
            string sizeLabel=pages>300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion

            #region 5
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for(int i=0; i<books.Length;i++)
            {
                Console.WriteLine($"book {i+1}:{books[i]}");
            }
            #endregion

            #region 6
            Console.WriteLine("Using while loop");
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine($"book {count + 1}: {books[count]}");
                count++;
            }
            #endregion

            #region 7
            int cnt = 0;
            do

            {
                Console.WriteLine("Checking book...");
                cnt++;
            }while (cnt < 3);
            #endregion

            #region 8
            Console.WriteLine("Using foreach loop");
            foreach (string book in books)
            {
                Console.WriteLine($"Book: {book}");
            }
            #endregion

            #region 9
            for (int i = 0; i < books.Length; i++)
            {
                if(books[i] == "Refactoring")
                { 
                    break;
                }
                else
                {
                    Console.WriteLine($"book {i + 1}:{books[i]}");
                }
                
            }
            #endregion

            #region 10
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "The Pragmatic Programmer")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"book {i + 1}:{books[i]}");
                }
            }
            #endregion

            #region 11

            void PrintFirstBook()
            {
                if (books.Length == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine($"First book: {books[0]}");
                }
                
            }
            PrintFirstBook();
            #endregion


        }
    }
}
