using System;
namespace bai1
{
    public class timsohh
    {
        public static void Main(string[] args)
        {
            int sum, i, n;
            int mm, mx;
            Console.Write("nhap vao so bat dau.");
            mm= Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap vao so ket thuc.");
            mx= Convert.ToInt32(Console.ReadLine());
            Console.Write("cac so hoan hao la: ");
            for (i = mm; i <= mx; i++)
            {
                n = 1;
                sum = 0;
                while (n < i)
                {
                    if (i % n == 0)
                    
                        sum = sum + n;
                        n++;
                    
                }
                if (sum == i)
                
                    Console.Write("{0},", i);
                
                
            }
           
        }
    }
}
