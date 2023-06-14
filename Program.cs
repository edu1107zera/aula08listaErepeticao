using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula08ListasERepeticao
{
    class Program
    {
       
        static void Main(string[] args)
        {

            List<string> nomes = new List<string>();
            nomes.Add("stella");
            nomes.Add("william");
            nomes.Add("luis"); 
            nomes.Add("eduardo");
            nomes.Add("eduardo");
            nomes.Add("leonardo");
            nomes.Add("stella");
            nomes.Add("william");
            nomes.Add("luis");
            nomes.Add("eduardo");
            nomes.Add("eduardo");
            nomes.Add("leonardo");


            int contador = 0;
            while(contador < nomes.Count)
            {
                Console.WriteLine("o nome é " +nomes[contador]);
                contador++;
               
            }


            Console.ReadKey();


        }

        void lista()
        {
            List<string> nomes = new List<string>();
            nomes.Add("edu");
            nomes.Add("vitor");
            nomes.Add("rosana");

            Console.WriteLine("Nome:" + nomes[0]);
            Console.WriteLine("Nome:" + nomes[1]);
            Console.WriteLine("Nome:" + nomes[2]);

            nomes.RemoveAt(1);


            int quantidade = nomes.Count;
            Console.WriteLine($"existem {quantidade} itens dentro da lista");

            Console.ReadKey();
        }
        void array()
        {
            string[] nomes = new string[3];
            nomes[0] = "edu";
            nomes[2] = "lombardor";
            nomes[1] = "leo";

            Console.WriteLine("o nome da primeira pessoa é " + nomes[0]);
            Console.WriteLine("o nome da segunda pessoa é " + nomes[1]);

        }
        void repeticao()
        {
            int contador = 0;

            while (contador < 7)
            {
                Console.WriteLine("ola");
                contador = contador + 1;  //contador++ //contador +=1 //conador /=1............- *


            }

            Console.ReadKey();
        }
        /*
            public static List<string> nomes = new List<string>();
        static void Main(string[] args)
        {
            int valorC;
            nomes.Add("");

            Console.WriteLine("cadastro de usuarios:");
            Console.WriteLine("1-cadastrar");
            Console.WriteLine("2-buscar");
            Console.Write("digite uma opçao: ");
            valorC = int.Parse(Console.ReadLine());


            if (valorC == 1)
            {
                Console.Write("digite seu nome: ");
                nomes.Add(Console.ReadLine());
            }
            Console.WriteLine("");
        

        }
        */


    }
}
    
      
    

