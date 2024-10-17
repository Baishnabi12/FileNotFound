namespace ExceptionAssignment
{
    internal class ExceptionProgram4
    {

        class Program
        {
            static void Main()
            {
                string filePath = "file.txt";
                try
                {
                    string content = File.ReadAllText(filePath);
                    Console.WriteLine(content);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(" The file was not found.");
                }
            }
        }

    }
}
