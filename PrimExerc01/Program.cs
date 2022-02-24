using System;
using System.Globalization;

namespace PrimExerc01 {
    class Program {

        static void Main(string[] args) {

            Pessoa n1 = new Pessoa();
            Pessoa n2 = new Pessoa();
            Pessoa id1 = new Pessoa();
            Pessoa id2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            n1.Nome = Console.ReadLine();
            Console.Write("Digite a idade dessa pessoa :");
            id1.Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome da segunda pessoa: ");
            n2.Nome = Console.ReadLine();
            Console.Write("Digite a idade dessa segunda pessoa: ");
            id2.Idade = int.Parse(Console.ReadLine());

            if(id1.Idade > id2.Idade) {
                Console.WriteLine("\n"+ n1.Nome +" é mais velho(a)");
            }
            else if(id1.Idade == id2.Idade) {
                Console.WriteLine("Os dois tem a mesma idade!");
            }
            else {
                Console.WriteLine(n2.Nome + " é mais velho(a)");
            }

            //Novo códigozinho

            Console.Write("\n\nAgora vou calcular a média de salários dessas pessoas");

            Pessoa sal1 = new Pessoa();
            Pessoa sal2 = new Pessoa();

            Console.Write("\nMe diga quanto que "+ n1.Nome + " recebe: ");
            sal1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Agora quanto "+ n2.Nome + " recebe?: ");
            sal2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (sal1.Salario + sal2.Salario) / 2.00;

            Console.Write("\nA média salarial é: "+ media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\n\nFim!\n\n");

        }
    }
}