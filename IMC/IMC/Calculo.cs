using System;
using System.Collections.Generic;
using System.Text;

namespace IMC
{
    public class Calculo
    {

        public string Nome { get; set; }
        public double Peso  { get; set; }
        public double Altura { get; set; }
        public double Resultado { get; set; }

        public void Calcular()
        {

            Console.WriteLine("Qual o seu nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual e o seu Peso: (xx,xx)");
            Peso = Double.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua Altura: (x,xx)");
            Altura = double.Parse(Console.ReadLine());


            Resultado = Math.Round(Peso /(Altura * Altura));

            Console.Write(Nome + "O seu IMC é: " + Resultado);
        }
    }
}
