namespace Labexam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\cdac_tvm\\7 .net\\Labdemo.txt";
            string fileContent = "Hello and Welcome\nIt is the first content\nof the text file mytest.txt";


            File.WriteAllText(filePath, fileContent);


            string readFileContent = File.ReadAllText(filePath);


            Console.WriteLine($"Here is the content of the file {filePath}:");
            Console.WriteLine(readFileContent);

        }
    }
}