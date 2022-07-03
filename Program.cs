using System;
using ProjetoCinemaCSharp.Classes;

namespace ProjetoCinemaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Bem vindo ao Cinema's Dudu!");
            Console.Write(" Gostaria de comprar ingressos? (sim ou não): ");
            string perguntaInicial = Console.ReadLine();
            perguntaInicial = perguntaInicial.ToLower();
            if(perguntaInicial == "sim")
            {
                Console.WriteLine("\n Os filmes disponíveis são: ");
                Console.WriteLine(" 1- Doutor Estranho no Multiverso da Loucura");
                Console.WriteLine(" 2- Top Gun: Maverick");
                Console.WriteLine(" 3- Jurassic World: Domínio");
                Console.WriteLine(" 4- Lightyear");
                Console.Write("\n Qual desses filmes você quer? (digite o número na frente do filme): ");
                int perguntaFilme = int.Parse(Console.ReadLine());
                switch(perguntaFilme)
                {
                    case 1:
                    {
                        Cinema c = new Cinema("Doutor Estranho no Multiverso da Loucura");
                        c.Data("maio", 5, 31, "junho", 1, 5);
                        c.TresD();
                        c.perguntaTresD = Console.ReadLine();
                        c.Horario();
                        c.ValorIngresso();
                        c.Pagamento();
                        break;
                    }
                    case 2:
                    {
                        Cinema t = new Cinema("Top Gun: Maverick");
                        t.Data("maio", 26, 31, "junho", 1, 26);
                        t.TresD();
                        t.perguntaTresD = Console.ReadLine();
                        t.Horario();
                        t.ValorIngresso();
                        t.Pagamento();
                        break;
                    }
                    case 3:
                    {
                        Cinema j = new Cinema("Jurassic World: Domínio");
                        j.Data("junho", 2, 30, "julho", 1, 2);
                        j.TresD();
                        j.perguntaTresD = Console.ReadLine();
                        j.Horario();
                        j.ValorIngresso();
                        j.Pagamento();
                        break;
                    }
                    case 4:
                    {
                        Cinema l = new Cinema("Lightyear");
                        l.Data("junho", 16, 30, "julho", 1, 16);
                        l.TresD();
                        l.perguntaTresD = Console.ReadLine();
                        l.Horario();
                        l.ValorIngresso();
                        l.Pagamento();
                        break;
                    }
                    default:
                    {
                        throw new Exception("\n\n Você digitou errado, feche o programa e tente novamente \n");
                    }
                }
            }
            else if(perguntaInicial == "não" || perguntaInicial == "nao")
            {
                Console.WriteLine("\n Tudo bem, agradecemos a sua visita!");
            }
            else
            {
                throw new Exception("\n\n Você digitou errado, feche o programa e tente novamente \n");
            }

        }
    }
}