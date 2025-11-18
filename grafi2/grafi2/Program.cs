namespace grafi2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
            int pocet_lidi = Convert.ToInt32(Console.ReadLine());

            int[,] graf = new int[pocet_lidi, pocet_lidi];

            string[] dvojice = Console.ReadLine().Split();

            for (int i = 0; i < dvojice.Length; i++)
            {
                int x = Convert.ToInt32(dvojice[i].Split("-")[0])-1;
                int y = Convert.ToInt32(dvojice[i].Split("-")[1])-1;
                graf[x, y] = 1;
                graf[y, x] = 1;
            }
            string[] xz = Console.ReadLine().Split();
            int start = Convert.ToInt32(xz[0]) -1;
            int cil = Convert.ToInt32(xz[1])-1;


            Queue<int> fronta = new Queue<int>();
            int[] vrstva = new int[pocet_lidi];
            int[] predchozi = new int[pocet_lidi];
            int[] otevrenost = new int[pocet_lidi];
            int kolo = -1;

            fronta.Enqueue(start);
            otevrenost[start] = 1;

            while (fronta.Count > 0) 
            {   
                int vrchol = fronta.Dequeue();
                kolo = kolo + 1;
                for (int i = 0; i < pocet_lidi; i++)
                {
                    if (graf[vrchol, i] == 1 && otevrenost[i] == 0)
                    {
                        vrstva[i] = kolo;
                        predchozi[i] = vrchol;
                        fronta.Enqueue(i);
                        otevrenost[i] = 1;



                    }
                }
                
                
            }
            Console.WriteLine(vrstva[cil]);

        }
    }
}
