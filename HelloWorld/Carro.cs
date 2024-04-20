
namespace HelloWorld;

class Carro
{
    public void TurnOn()
    {
        Console.WriteLine("Carro ligado");
    }

    public void TurnOff()
    {
        Console.WriteLine("Carro desligado");
    }

    private void Teste1()
    {
        Console.WriteLine("Teste1");
    }

    internal void Teste2()
    {
        Teste1();
        Console.WriteLine("Teste2");
    }
}
