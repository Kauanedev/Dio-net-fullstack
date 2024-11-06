using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFundamentos.Common.Models

{
    public class Calculadora
    {

        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} : {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {potencia}");
        }
        public void Seno(double angulo)
        {
            //Para utilizar a func de sin devemos converter o valor para radianos primeiro
            double rad = angulo * Math.PI / 180;
            double sen = Math.Sin(rad);

            Console.WriteLine($"Seno de {angulo}° = {Math.Round(sen, 4)}");
        }
        public void Coseno(double angulo)
        {
            double rad = angulo * Math.PI / 180;
            double cos = Math.Cos(rad);

            Console.WriteLine($"Seno de {angulo}° = {Math.Round(cos, 4)}");
        }
        public void Tangente(double angulo)
        {
            double rad = angulo * Math.PI / 180;
            double tg = Math.Tan(rad);

            Console.WriteLine($"Seno de {angulo}° = {Math.Round(tg, 4)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {Math.Round(raiz, 4)}");
        }
    }
}