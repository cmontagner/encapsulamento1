namespace Encapsulamento1
{
    // informando Comprimento e Largura através de recursos da interface com usuário
    class RetanguloEncapsulado
    {
        //Variáveis membros
        private double Comprimento;
        private double Largura;
    
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

        public void InformarValores()
        {
            Console.WriteLine("Informe o comprimento: ");
            Comprimento = Convert.ToDouble( Console.ReadLine() );

            Console.WriteLine("Informe a largura: ");
            Largura = Convert.ToDouble(Console.ReadLine());
        }
    }
}
