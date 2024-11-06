using System;
using System.Collections.Generic;

List<string> stringList = ["RJ", "SP", "MG"];

stringList.Add("BA");

int contador = 0;
foreach (string item in stringList)
{
    Console.WriteLine($"Posição N° {contador} - {item}");
    contador++;
}

Console.WriteLine($"Quantidade de itens na lista: {stringList.Count}");
Console.WriteLine($"Capacidade da lista: {stringList.Capacity}");

stringList.Remove("MG");

Console.WriteLine($"Quantidade de itens na lista: {stringList.Count}");
Console.WriteLine($"Capacidade da lista: {stringList.Capacity}");

stringList.Add("ES");

Console.WriteLine($"Quantidade de itens na lista: {stringList.Count}");
Console.WriteLine($"Capacidade da lista: {stringList.Capacity}");





