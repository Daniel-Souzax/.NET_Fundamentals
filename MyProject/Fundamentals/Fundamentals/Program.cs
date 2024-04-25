namespace Fundamentals;

class Program
{  
      
    enum Cores
    {
        Verde, 
        Preto,
        Laranja,
        Lilas
    }
    static void Main()
    {
        string autor = "Dan";
        Cores cor = Cores.Preto;
        int numero = 1;

        string resultado = numero switch
        {
            7 => "Dan",
            1 => "Sara",
            3 => "lele",
            _ => "Nome desconhecido"
        };

        Console.WriteLine(resultado);

        //Switch normal
        /*
        switch (cor)
        {
            case Cores.Laranja:
                {
                    Console.WriteLine("Laranja");
                }
                break;
            
            case Cores.Lilas:
                {
                    Console.WriteLine("Lilas");
                }
                break;
            
            default:
                {
                    Console.WriteLine("nenhuma das anteriores");
                }
                break;
            
        }
        */

    }

}

