using System;

namespace EtecAB
{
    class Program
    {
        static void Main(string[] args)
        {
            string cidade = "Mongaguá";
            string estado = "SP";
            
            string mensagem = $"A Etec ADolpho Berezin Fica Em ";
            string mensagem2 =$"{cidade}/{estado}.";
            string separador = $"-------------------------------------------";
            string endereço = $"Av. Monteiro Lobato, 8000 - Bal. Jussara. 11730-000";

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(mensagem);
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(mensagem2);
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(separador);
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Endereço: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(endereço);
            
            Console.ResetColor();
        }
    }
}
