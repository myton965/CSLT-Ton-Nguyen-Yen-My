using System;
using System.Collections.Generic;
using System.Text;

namespace mietorn.Buổi_4
{
    internal class giaiphuongtrinhb2
    {  
        static void giaiPT(int a, int b, int c)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bài tập giải phương trình bậc 2 ax^2+bx+c=0
            if (a==0)
            {
                if (b==0)
                {
                    if (c==0)
                    {
                        Console.WriteLine("Vô số nghiệm, x tùy ý");
                    }
                    else
                    {
                        Console.WriteLine("Vô nghiệm (vô lý)");
                    }
                }
                else
                {
                    if (c==0)
                    {
                        Console.WriteLine("x=0");
                    }
                    else
                    {
                        Console.WriteLine($"x= {-c/b} ");
                    }
                }
            }
            else
            {
                if (b==0)
                {
                    if (c==0)
                    {
                        Console.WriteLine("x=0");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                else
                {

                }
            }

        }
               
            

        
    }
}
