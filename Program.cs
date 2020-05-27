using System;

namespace Atividade_Aula_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string ligar = "0";
            string ligação = "0";
            Celular samsung = new Celular();
            samsung.cor = "Sua cor é branca";
            samsung.modelo = "J5 prime";
            samsung.ligado = true;

            Console.WriteLine("O Modelo do celular é" + samsung.modelo);
            Console.WriteLine("Sua cor é:" + samsung.cor);
            Console.WriteLine("O celular esta ligado?");
            ligar = Console.ReadLine();

            if(ligar == "n" || ligar == "não" || ligar == "Não" ){
                  Console.Clear();
                Console.WriteLine("O celular está deligado!");
                Console.WriteLine("Obrigado por utilizar está plataforma");
            }else{ if(ligar == "s" || ligar == "Sim" || ligar == "sim")
                Console.Clear();
                Console.WriteLine("O celular está ligado!");
                Console.WriteLine("Gostaria de fazer alguma ligação?");
                ligação = Console.ReadLine();
                
            }

        }
    }
}
