using System;
using Figgle;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome,rendamensal,valorDoEmprestimo,quantidadeDeParcelas;
            int Parcelas,idade;
            decimal valorParcela,valorMaximoParcela,Renda,valor;
            bool rendaOK,valorOK,parcelaOK; 

            Console.WriteLine("----Credito Consignado----");

            Console.WriteLine("Digite Seu Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite Sua Idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            Console.WriteLine($"idade: {idade} anos");  

            if (idade <= 18)
            {
            Console.WriteLine($"Nome:{nome}");
            Console.ForegroundColor  =  ConsoleColor.Red;
            Console.WriteLine("Você Não Pode Solicitar Um Empréstimo ");
            Console.WriteLine("A Idade Minima É De 18 Anos!");
            Console . ResetColor ();
            Console.ResetColor();
            Environment.Exit(-1);
            } 

            if (idade >= 18)
            {
            Console.WriteLine($"Nome:{nome}");
            Console.ForegroundColor  = ConsoleColor.Green;
            Console.WriteLine("Parabéns Você Pode fazer A Solicitação Do Empréstimo ");
            Console.WriteLine("A Idade Minima É De 18 Anos!");
            Console.ResetColor();
            Console.ReadKey();
            } 

            Console.WriteLine($"Senhor(a):{nome} Qual o Valor Desejado? ");
            valorDoEmprestimo = Console.ReadLine();

            Console.WriteLine($"Senhor(a):{nome} Em Quantas Parcelas Deseja? ");
            quantidadeDeParcelas = Console.ReadLine();

            Console.WriteLine($"Senhor(a):{nome} Qual o Valor Da Sua Renda Mensal? ");
            rendamensal = Console.ReadLine();


            valorOK = Decimal.TryParse(valorDoEmprestimo, out valor );
            parcelaOK = Int32.TryParse(quantidadeDeParcelas, out  Parcelas );
            rendaOK = Decimal.TryParse(rendamensal, out  Renda );

            valorParcela = valor / Parcelas;
            valorMaximoParcela = Renda * 0.3m;

            Console.WriteLine($" Valor Da Parcela ...: { valorParcela:C}");
            Console.WriteLine($" Parcela Máxima .....: { valorMaximoParcela:C}");

           
            if (valorParcela <= valorMaximoParcela)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Parabéns, Seu Crédito Foi Aprovado!");
            Console.ResetColor ();
            Console.WriteLine(FiggleFonts.Starwars.Render("Obrigado Pela Preferência!"));
            Console.ReadKey();
            }

            else
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Nome:{nome} Desculpe, Seu Crédito Não Foi Aprovado.");
            Console.ResetColor ();
            Console.ReadKey();
            }
                                  
        }
    }
}
