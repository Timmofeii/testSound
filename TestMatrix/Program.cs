using System;

public class Program: Program047
{


    static void Main(string[] args)
    {
        CreateMatrix.Program047 p47 = new CreateMatrix.Program047();
        p47.CreateAndFullArr(3, 3, 0, 10);
      
    }
}
namespace CreateMatrix
{
    public class Program047
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter row array");
            int row = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter col array");
            int col = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter start double arr");
            double startArr = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Enter end double arr");
            double endArr = Convert.ToDouble(Console.ReadLine());



            // double[][] arr = CreateAndFullArr(row, col, startArr,endArr);


        }
        public static double[][] CreateAndFullArr(int row, int col, double startArr, double endArr)
        {
            double[][] arr = new double[row][];
            Random rd = new Random();
            for (int i = 0; i < row; i++)
            {
                arr[i] = new double[col];
                System.Console.Write("[");
                for (int j = 0; j < arr.Length; j++)
                {

                    arr[i][j] = Math.Round((rd.NextDouble() * (endArr - startArr) + startArr), 2);

                    System.Console.Write(" " + arr[i][j]);

                }
                System.Console.WriteLine(" ]");


            }
            return arr;
        }
    }
}
