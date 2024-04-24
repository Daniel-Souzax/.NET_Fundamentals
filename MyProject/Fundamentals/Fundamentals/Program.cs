namespace Fundamentals;

class Program
{   
    static void Main()
    {
        int numero = 10;

        var carro = new Carro
        {
            Modelo = "ka",
            LancadoEm = new DateOnly(2005, 01, 01),
            Cor = Cor.Prata

        };

        carro.NomeDoModelo();

        Console.WriteLine("oi");

    }
}
