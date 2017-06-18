using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozawozaloza
{
    class Program
    {
        static void Main(string[] args)
        {
            int Counterstart = 1 , counterend = 111 ;
            int n;
           for (int i = Counterstart; i < counterend; ++i){
                if (i % 3 == 0 ){ 
                    
                     Console.Write("Coza");
                }
                 else if (i % 5 == 0){
                    Console.Write("Loza");
                }
                else if (i % 7 == 0){
                    Console.Write("Woza");
                }
                else if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0){
                    Console.Write(i);
                }
                if (i % 11 == 0){
                    Console.WriteLine();
                }
                else {
                    Console.Write(" ");
                }
			}Console.ReadKey();
            }
        }
    }          
}
    

