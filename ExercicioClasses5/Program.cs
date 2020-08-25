using System;
using System.Globalization;
namespace ExercicioClasses5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
            ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
            para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
            este problema.*/

            var aluno = new Aluno();

            Console.WriteLine("Digite nome:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite primeira nota:");
            aluno.PrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite segunda nota:");
            aluno.SegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite terceira nota:");
            aluno.TerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final: "+ aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado()== true)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Falta " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " para aprovação.");
            }

        }
    }
}
