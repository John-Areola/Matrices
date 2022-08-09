namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] fourBfour = new int[,] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };

            FourByFourMatrice mat4x4 = new FourByFourMatrice();
            int determinant = mat4x4.GetDeterminant(fourBfour);
            Console.WriteLine("This is the determinant {0}", determinant);
        }
    }
}