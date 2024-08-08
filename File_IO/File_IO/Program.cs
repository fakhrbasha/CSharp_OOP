using System.IO;
using System.Text;
namespace File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read
            /* 1. StreamReader Fakhr = new StreamReader (@"C:\Users\Fakhr Basha\Desktop\FIle.txt");
             string line;
           while((line = Fakhr.ReadLine()) != null)
           {
               Console.WriteLine(line);
           }*/

            // 2. file.ReadAllLine return array
            string[] result = File.ReadAllLines(@"C:\Users\Fakhr Basha\Desktop\FIle.txt");

            foreach (string line in result)
            {
                Console.WriteLine(line);
            }

            // write
            string filepath = ("C:\\Users\\Fakhr Basha\\Desktop\\write.txt");
            /* 1.
            StreamWriter writer = new StreamWriter(filepath);
            for (int i = 0; i < 5; i++)
            {
                writer.WriteLine("Write Here");
            }
            
            writer.Close();*/
            // 2.
            string Content = "\nAli";
            //File.WriteAllText(filepath, Content);

            // append

            File.AppendAllText(filepath, Content);


        }
    }
}
