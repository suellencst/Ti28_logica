using System;

namespace pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time;

            Console.WriteLine("Digite o tempo de entrega: "); 
            time = Convert.ToInt32(Console.ReadLine());

            if(time <= 15)
            {
                Console.WriteLine("Entrega prefeita! Bônus garantido.");
            }

            if (time > 15 && time < 30)
            {
                Console.WriteLine("Pizza entregue a tempo, sem bônus.");
            }

            if (time >= 30)
            {
                Console.WriteLine("A pizza esfriou! Peter foi demitido!"); 

            }

            Console.WriteLine("A pizza esfriou! Peter foi demitido!"); 
        }
    }
}
