using HelloWorld.Teste;
using System;

namespace HelloWorld;

class Program
{
   static void Main()
    {
        // Inteiros
        int numero = 7;
        long numero2 = 7;
        uint numero3 = 7;
        sbyte numero4 = -127;
        byte numero5 = 255;

        // Decimais 
        double number1 = 3.14;
        float number2 = 3.14f;
        decimal number3 = 3.14m;
        int soma1 = 1_000;

        // Booleano
        Boolean ativo = true;
        Boolean inativo = false;

        // Texto1
        char letra = 'a';
        char numerozada = '1';
        char caracter = '@';

        string texto = "Hello World";
        char primeiraLetraDoTexto = texto[0];

        string meuNome = "            Daniel souza         ";
        string nomeSemEspaco = meuNome.Trim();

        Boolean comecaComALetraW = nomeSemEspaco.StartsWith("Dan");
        string mudancaDeNome = nomeSemEspaco.Replace("Dan", "Gabr");

        bool existe = texto.Contains("World");
        Console.WriteLine(existe);
        
 
    }
}