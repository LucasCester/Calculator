using System;

namespace Calculadora
{
  class Program 
  {
    static void Main(string[] args)
    {
      Menu();
    }

    public static void Menu(){
      Console.Clear();

      bool  digitouErrado = true;
      int op = 0;

      decimal v1 = 0;
      decimal v2 = 0;

      decimal resultado = 0;

      do
      {
        Console.WriteLine("----------------------");
        Console.WriteLine();
        Console.WriteLine("Digite o número referente ao operador desejado: ");        
        Console.WriteLine("1 - Adição");   
        Console.WriteLine("2 - Subtração");   
        Console.WriteLine("3 - Multiplicação");   
        Console.WriteLine("4 - Divisão"); 
        Console.WriteLine("5 - Sair"); 
        Console.Write("> ");
        
        var valorDigitado = Console.ReadLine();

        if(!int.TryParse(valorDigitado, out op))
        {
          digitouErrado = true;
          Console.Clear();
          Console.WriteLine("Valor incorreto.");
        }
        else
          digitouErrado = false;
      }
      while(digitouErrado);

      Console.WriteLine(); 

      if(op == 5){
        Console.WriteLine("Obrigado por nossa calculadora."); 
        Environment.Exit(0);
      }

      v1 = PegaValor("Digite o primeiro Valor: ");
      v2 = PegaValor("Digite o segundo Valor: ");

      switch(op)
      {
        case 1: resultado = v1 + v2; break;
        case 2: resultado = v1 - v2; break;
        case 3: resultado = v1 * v2; break;
        case 4: resultado = v1 / v2; break;
      }

      Console.WriteLine("O resultado é: " + resultado);
      Console.ReadKey();
      Menu();
    }

    public static decimal PegaValor(string fala){

      bool digitouErrado = true;
      decimal retorno = 0;

      do
      {
        Console.WriteLine(fala);
        Console.Write("> ");

        var valorDigitado = Console.ReadLine();

        Console.WriteLine();

        if(!decimal.TryParse(valorDigitado, out retorno))
        {
          digitouErrado = true;
          Console.WriteLine("Valor incorreto.");
        }
        else
          digitouErrado = false;
      }
      while(digitouErrado);
      
      return retorno;
    }
  }
}