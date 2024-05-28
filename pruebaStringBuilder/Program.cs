using System.Text;

namespace pruebaStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            sb1.Append("hola");
            sb1.Append(" ");
            sb1.Append("mundo");

            sb2.AppendLine("hola");
            sb2.AppendLine("mundo");
            sb2.Replace("mundo", "c#");

            string sb1String = sb1.ToString();
            string sb2String = sb2.ToString();

            Console.WriteLine(sb1String);
            Console.WriteLine(sb2String);

        }
    }
}
