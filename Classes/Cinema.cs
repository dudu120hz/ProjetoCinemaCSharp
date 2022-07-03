using System;

namespace ProjetoCinemaCSharp.Classes
{
    public class Cinema : AMolde
    {
        public Cinema(string nome)
        {
            Console.WriteLine($" Você escolheu {nome}!");
        }

        public override void Data(string mesInicio, int diaInicioMes1, int diaFimMes1, string mesFim, int diaInicioMes2, int diaFimMes2)
        {
            Console.Write($"\n Que mês você quer? ({mesInicio} ou {mesFim}): ");
            string perguntaMes = Console.ReadLine();
            perguntaMes = perguntaMes.ToLower();
            if(perguntaMes == mesInicio)
            {
                Console.WriteLine($" Você escolheu o mês de {mesInicio}!");
                Console.Write($" Que dia você quer? (digite de {diaInicioMes1} a {diaFimMes1}): ");
                int perguntaDia = int.Parse(Console.ReadLine());
                if(perguntaDia >= diaInicioMes1 && perguntaDia <= diaFimMes1)
                {
                    Console.WriteLine($" Você escolheu o dia {perguntaDia} de {mesInicio}!");
                }
                else
                {
                    throw new Exception("\n\n Você digitou errado, feche o programa e tente novamente \n");
                }
            }
            else if(perguntaMes == mesFim)
            {
                Console.WriteLine($" Você escolheu o mês de {mesFim}!");
                Console.Write($" Que dia você quer? (digite de {diaInicioMes2} a {diaFimMes2}): ");
                int perguntaDia = int.Parse(Console.ReadLine());
                if (perguntaDia >= diaInicioMes2 && perguntaDia <= diaFimMes2)
                {
                    Console.WriteLine($" Você escolheu o dia {perguntaDia} de {mesFim}!");
                }
                else
                {
                    throw new Exception("\n\n Você digitou errado, feche o programa e tente novamente \n");
                }
            }
            else
            {
                throw new Exception("\n\n Você digitou errado, feche o programa e tente novamente \n");
            }
        }

        public override void TresD()
        {
            Console.Write("\n Você quer com 3D? (sim ou não): ");
        }

        public string perguntaTresD;

        public override void Horario()
        {
            if(perguntaTresD == "sim")
            {
                Console.WriteLine(" Você escolheu com 3D!");
                Console.WriteLine("\n Os horários disponíveis são:");
                Console.WriteLine(" 14h20   16h05");
                Console.WriteLine(" 18h00   20h35");
                Console.WriteLine(" 22h50");
                Console.WriteLine("\n Qual desses horários você quer?");
                Console.Write(" (digite os dois primeiros números, ex: '18'): ");
                string perguntaHorario = Console.ReadLine();
                switch (perguntaHorario)
                {
                    case "14":
                    {
                        perguntaHorario += "h20";
                        break;
                    }
                    case "16":
                    {
                        perguntaHorario += "h05";
                        break;
                    }
                    case "18":
                    {
                        perguntaHorario += "h00";
                        break;
                    }
                    case "20":
                    {
                        perguntaHorario += "h35";
                        break;
                    }
                    case "22":
                    {
                        perguntaHorario += "h50";
                        break;
                    }
                    default:
                    {
                        throw new Exception("\n\n Você digitou errado, feche o programa e tente novamente \n");
                    }
                }
                Console.WriteLine($" Você escolheu o horário das {perguntaHorario}!");
            }
            else if(perguntaTresD == "não" || perguntaTresD == "nao")
            {
                Console.WriteLine(" Você escolheu sem 3D!");
                Console.WriteLine("\n Os horários disponíveis são:");
                Console.WriteLine(" 13h45   15h15");
                Console.WriteLine(" 17h30   19h15");
                Console.WriteLine(" 21h05");
                Console.WriteLine("\n Qual desses horários você quer?");
                Console.Write(" (digite os dois primeiros números, ex: '17'): ");
                string perguntaHorario = Console.ReadLine();
                switch(perguntaHorario)
                {
                    case "13":
                    {
                        perguntaHorario += "h45";
                        break;
                    }
                    case "15":
                    {
                        perguntaHorario += "h15";
                        break;
                    }
                    case "17":
                    {
                        perguntaHorario += "h30";
                        break;
                    }
                    case "19":
                    {
                        perguntaHorario += "h15";
                        break;
                    }
                    case "21":
                    {
                        perguntaHorario += "h05";
                        break;
                    }
                    default:
                    {
                        throw new Exception("\n\n Você digitou errado, feche o programa e tente novamente \n");
                    }
                }
                Console.WriteLine($" Você escolheu o horário das {perguntaHorario}!");
            }
            else
            {
                throw new Exception("\n\n Você digitou errado, feche o programa e tente novamente \n");
            }
        }

        public override void ValorIngresso()
        {
            double precoInteira;
            double precoMeia;
            if(perguntaTresD == "sim")
            {
                precoInteira = 48.00;
                precoMeia = 24.00;
            }
            else if(perguntaTresD == "não" || perguntaTresD == "nao")
            {
                precoInteira = 40.00;
                precoMeia = 20.00;
            }
            else
            {
                throw new Exception("\n\n Você digitou errado, feche o programa e tente novamente \n");
            }
            Console.WriteLine($"\n O valor dos ingressos de entrada-inteira é de R${precoInteira}");
            Console.WriteLine($" O valor dos ingressos de meia-entrada é de R${precoMeia}");
            Console.Write(" Quantos ingressos de entrada-inteira você quer? ");
            int quantInteira = int.Parse(Console.ReadLine());
            Console.Write(" Quantos ingressos de meia-entrada você quer? ");
            int quantMeia = int.Parse(Console.ReadLine());
            double valorInteira = precoInteira * quantInteira;
            double valorMeia = precoMeia * quantMeia;
            double valorTotal = valorInteira + valorMeia;
            Console.WriteLine($"\n O valor dos ingressos de entrada-inteira é de R${valorInteira}");
            Console.WriteLine($" O valor dos ingressos de meia-entrada é de R${valorMeia}");
            Console.WriteLine($" O valor total dos ingressos é de R${valorTotal}");
        }

        public override void Pagamento()
        {
            Console.WriteLine("\n As formas de pagamento são:");
            Console.WriteLine(" 1- Cartão");
            Console.WriteLine(" 2- Boleto");
            Console.WriteLine(" 3- Pix");
            Console.Write(" Qual dessas formas você quer pagar? (digite o número na frente da opção): ");
            int perguntaPagamento = int.Parse(Console.ReadLine());
            switch (perguntaPagamento)
            {
                case 1:
                {
                    Console.WriteLine("\n Você escolheu Cartão!");
                    Console.Write(" Agora digite o número do cartão: ");
                    string numeroCartao = Console.ReadLine();
                    Console.Write(" Agora digite o código de segurança: ");
                    string codigoCartao = Console.ReadLine();
                    Console.WriteLine(" Pronto, tudo pago e computado no sistema!");
                    System.Console.WriteLine(" Tenha um bom filme e até a próxima! \n");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("\n Você escolheu Boleto!");
                    Console.WriteLine(" O código de barras do Boleto é:");
                    Console.WriteLine(" 450460632662665675710730750765835845855865870888");
                    Console.Write(" Digite seu número de telefone (com DDD e todos os números juntos): ");
                    string numeroTelefone = Console.ReadLine();
                    Console.WriteLine(" Você tem 5 dias úteis para efetuar o pagamento no Boleto");
                    Console.WriteLine(" Se não pagar nesse prazo, a compra será totalmente cancelada");
                    Console.WriteLine(" Assim que o pagamento for aprovado, vicê receberá um SMS de aviso");
                    Console.WriteLine(" Por enquanto é isso, agradecemos a sua compra e visita! \n");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("\n Você escolheu Pix!");
                    Console.WriteLine(" A chave do Pix é:");
                    Console.WriteLine(" dudu@cinema.com");
                    Console.Write(" Digite seu número de telefone (com DDD e todos os números juntos): ");
                    string numeroTelefone = Console.ReadLine();
                    Console.WriteLine(" Você tem 5 dias úteis para efetuar o pagamento no Boleto");
                    Console.WriteLine(" Se não pagar nesse prazo, a compra será totalmente cancelada");
                    Console.WriteLine(" Assim que o pagamento for aprovado, vicê receberá um SMS de aviso");
                    Console.WriteLine(" Por enquanto é isso, agradecemos a sua compra e visita! \n");
                    break;
                }
                default:
                {
                    throw new Exception("\n\n Você digitou errado, feche o programa e tente novamente \n");
                }
            }

        }
    }
}