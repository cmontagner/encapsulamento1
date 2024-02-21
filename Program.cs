using Encapsulamento1;

var retanguloNaoEncapsulado = new RetanguloNaoEncapsulado();
retanguloNaoEncapsulado.Comprimento = 2.5;
retanguloNaoEncapsulado.Largura = 1.5;
retanguloNaoEncapsulado.Exibir();
Console.ReadLine();

var retanguloEncapsulado = new RetanguloEncapsulado();
retanguloEncapsulado.InformarValores();
retanguloEncapsulado.Exibir();
Console.ReadLine();

var retanguloEncapsuladoValidacao = new RetanguloEncapsuladoValidacao();
try 
{
    Console.WriteLine("Informe o comprimento: ");
    retanguloEncapsuladoValidacao.Comprimento = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Informe a largura: ");
    retanguloEncapsuladoValidacao.Largura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Àrea do retângulo: {retanguloEncapsuladoValidacao.GetArea()}");
}
catch (ArgumentException argEx)
{
    Console.WriteLine($"Erro: {argEx.Message}");
    Console.ReadLine();
}