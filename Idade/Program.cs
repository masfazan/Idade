﻿//int idade;
Console.WriteLine("Digite sua idade: ");
int idade;
idade = int.Parse(Console.ReadLine());
    if (idade < 18)
{
    Console.WriteLine("Você é menor de idade.");
}
    else
{
    Console.WriteLine("Você é maior de idade.");
}
    Console.ReadLine();