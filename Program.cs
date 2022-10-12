internal class Program
{
    private static void Main(string[] args)
    {
        int[] A = new int[5];
        double[][] B = new double[3][];
        B[0] = new double[4];
        B[1] = new double[4];
        B[2] = new double[4];
        var rand = new Random();
        int sumA = 0;
        double sumB = 0;
        int multiA = 0;
        double multiB = 0;
        Console.WriteLine("Введите 5 чисел:");
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Convert.ToInt32(Console.ReadLine());
            
        }
        foreach (int i in A)
        {
            Console.Write(i+ " ");
        }
        for (int i = 0; i < A.Length; i++)
        {
            
            int temp = A[i];
            sumA = sumA + temp;
            
            multiA = multiA * temp;
        }
        Console.WriteLine();
        for (int i = 0; i < B.Length; i++)
        {
           
            for (int j = 0; j < B[i].Length; j++)
            {
                
                B[i][j] = Convert.ToDouble(Convert.ToString(rand.Next(10, 99)) + "," + Convert.ToString(rand.Next(10, 99)));
                Console.Write(B[i][j]);
                Console.Write(" ");
                double temp = B[i][j];
                sumB = sumB + temp;
                multiB = multiB * temp;
            }
            Console.WriteLine();
        }
        Console.WriteLine(sumA);
        Console.WriteLine(sumB);


    }
}