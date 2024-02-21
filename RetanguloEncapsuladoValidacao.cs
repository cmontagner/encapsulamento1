namespace Encapsulamento1
{
    //criando propriedades públicas, que permitem acessar o valor dos campos Comprimento e Largura
    //esta classe tem apenas uma responsabilidade: calcular a área do retângulo
    class RetanguloEncapsuladoValidacao
    {
        private double _comprimento;
        private double _largura;

        public double Comprimento 
        {
            get { return _comprimento; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("O valor do comprimento não pode ser menor que zero");
                else
                    _comprimento = value;
            }
        }

        public double Largura
        {
            get { return _largura; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("O valor da largura não pode ser menor que zero");
                else
                    _largura = value;
            }
        }

    
        public double GetArea()
        { 
            return _comprimento * _largura; 
        }
    }
}
