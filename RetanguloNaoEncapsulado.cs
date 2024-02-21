using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento1
{
    class RetanguloNaoEncapsulado
    {
        //Variáveis membros
        public double Comprimento;
        public double Largura;
    
        public double GetArea()
        { 
            return Comprimento * Largura; 
        }

        public void Exibir()
        {
            Console.WriteLine("Área do Retângulo\n");
            Console.WriteLine($"Comprimento: {Comprimento}\n");
            Console.WriteLine($"Largura: {Largura}\n");
            Console.WriteLine($"Área: {GetArea()}\n");
        }
    }
}
