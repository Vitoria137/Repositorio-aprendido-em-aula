using System;

class MainClass {
  public static void Main (string[] args) {
    string nome1, nome2, nome3;
    int idade1, idade2, idade3;

    Console.WriteLine("Escreva seu nome: ");
    nome1 = Console.ReadLine();
    Console.WriteLine("Escreva sua idade: ");
    idade1 = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Escreva seu nome: ");
    nome2 = Console.ReadLine();
    Console.WriteLine("Escreva sua idade: ");
    idade2 = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Escreva seu nome: ");
    nome3 = Console.ReadLine();
    Console.WriteLine("Escreva sua idade: ");
    idade3 = Int32.Parse(Console.ReadLine());

    if ((idade1 > idade2) && (idade1 > idade3)){
      Console.WriteLine("A pessoa mais velha é: " + nome1);
     }else if((idade2 > idade1) && (idade2 > idade3)){
      Console.WriteLine("A pessoa mais velha é: " + nome2);
    }else{
      Console.WriteLine("A pessoa mais velha é: " + nome3);
    }
  }
}