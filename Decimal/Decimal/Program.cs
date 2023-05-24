using System;
namespace DecToBinary
{
    class DeTBin
    {
        static  double n1 = 1.23;
        static double n2 = 3.12;
        int k1 = Convert.ToInt32(n1);
        int k2 = Convert.ToInt32(n2);
        
        public static void Main(string[] args)
        {
            DeTBin obj = new DeTBin();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(obj.k1);
            Console.WriteLine(obj.k2);
            Console.WriteLine(obj.Bconvertor(obj.k1));
            Console.WriteLine(obj.Bconvertor(obj.k2));
            Console.WriteLine(n1-obj.k1);
            Console.WriteLine(n2-obj.k2);

        }
        public string Bconvertor(int n)
        {
            string s1="";
            while(n!=0)
            {

                s1 += (char)n % 2;
                n = n /2;

            }
            return s1;
        }
        
    }
}