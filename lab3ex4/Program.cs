using System;

namespace lab3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti nr elemente din vector: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector=new int[n];
            Console.WriteLine("Introduceti elementele din vector: ");
            vector = CitireVector(n);
            Console.WriteLine("Cel mai mare element din vector este " + CelMaiMareNumar(vector));
            Console.WriteLine("Cel mai mic element din vector este " + CelMaiMicNumar(vector));
            Console.Write("Numerele divizivile cu 3 din vector sunt: ");
            DivTrei(vector);
            Console.WriteLine("");
            Console.Write("Numerele prime din vector sunt: ");
            NrPrim(vector);

        }
        static int[] CitireVector(int n)
        {
            int[] vector = new int[n];
            for(int i=0; i<n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }
            return vector;
        }
        static int CelMaiMareNumar(int[] vector)
        {
            int mare=vector[0];
            for(int i=0; i<vector.Length; i++)
            {
                if(vector[i]>mare)
                {
                    mare = vector[i];
                }
            }
            return mare;
        }
        static int CelMaiMicNumar(int[] vector)
        {
            int mic = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < mic)
                {
                    mic = vector[i];
                }
            }
            return mic;
        }
        static void DivTrei(int[] vector)
        {
            for(int i=0; i<vector.Length; i++)
            {
                if(vector[i]%3==0)
                {
                    Console.Write(vector[i] + " ");
                }
            }
        }
        static void NrPrim(int[] vector)
        {
            bool prim = false;
            for(int i=0; i<vector.Length; i++)
            {
                for(int j=2; j<=Math.Abs(vector[i]); j++)
                {
                    if(vector[i]%j==0)
                    {
                        if(Math.Abs(vector[i])!=j)
                        {
                            break;
                        }
                        else
                        {
                            prim = true;
                            Console.Write(vector[i] + " ");
                        }
                    }
                    
                }
                /*for (int j = -2; j >= vector[i]; j--)
                {
                    if (vector[i] % j == 0)
                    {
                        if (vector[i] != j)
                        {
                            break;
                        }
                        else
                        {
                            prim = true;
                            Console.Write(vector[i] + " ");
                        }
                    }

                }*/
            }
            if(prim==false)
            {
                Console.Write("nu sunt numere prime in vector");
            }
        }
    }

}
