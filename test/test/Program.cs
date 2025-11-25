namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static double vzdalenost(int[] a , int[]b)
            {
                return Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2))  ;
            }
            int konec = 0;
            while (konec==0)
            {   
                string p = Console.ReadLine();
                if (p =="q")
                {
                    konec=1 ;
                    
                }
                else
                {
                    int[] bod_x = { Convert.ToInt32(p), Convert.ToInt32(Console.ReadLine()) };
                    int[] bod_y = { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };
                    int[] bod_z = { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };

                  
                    if (vzdalenost(bod_x, bod_y)+ vzdalenost(bod_x, bod_z)< vzdalenost(bod_y, bod_z))
                    {
                        Console.WriteLine("toto neni trojuhelnik");
                    }
      
                    else
                    {
                        Console.WriteLine(vzdalenost(bod_x, bod_y));
                        Console.WriteLine(vzdalenost(bod_x, bod_z));
                        Console.WriteLine(vzdalenost(bod_y, bod_z));

                    }
                    

                }
            }
        }      
    }
}
