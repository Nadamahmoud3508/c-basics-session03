using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace string_part
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            string title = "clean code";
            string UpperTitle= title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(UpperTitle);
            #endregion

            #region 2
            string s1 = "Clean Code"; 
            string s2 = "Clean Code";
            Console.WriteLine(object.ReferenceEquals(s1, s2));
            #endregion

            #region 3
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb);
            #endregion

            #region 4
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);
            #endregion

            #region 5
            int pages = 464;
            Console.WriteLine("using + operator");  
            Console.WriteLine("Book: " + title + ", Pages: " + pages);
            #endregion

            #region 6
            Console.WriteLine("using $ operator");
            Console.WriteLine($"Book: {title}, Pages: {pages}");
            #endregion

            #region 7
            Console.WriteLine("using string.Format");
            Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title, pages));
            #endregion
        }
    }
}
