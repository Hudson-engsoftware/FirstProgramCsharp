using System;

namespace course{


class Program{

static void Main(string[] args){
    

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

Console.WriteLine("Dados da Primeira Pessoa : ");
Console.WriteLine("Nome : ");
p1.Nome = Console.ReadLine();
Console.WriteLine("Idade : ");
p1.idade = int.Parse(Console.ReadLine());


Console.WriteLine("Dados da Segunda Pessoa : ");
Console.WriteLine("Nome : ");
p2.Nome = Console.ReadLine();
Console.WriteLine("Idade : ");
p2.idade = int.Parse(Console.ReadLine());


    if(p1.idade > p2.idade){
        Console.WriteLine("A Pessoa mais velha : "+ p1.Nome);
    }else{
        Console.WriteLine("A Pessoa mais velha e : "+ p2.idade);
      }

    }
  }
}





