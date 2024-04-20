//Faça um programa que receba a idade de 10 pessoas e mostre a quantidade de maiores e menores de idade;

//Início do programa

using System.ComponentModel.Design;

Console.WriteLine("--- Menor e Maioridade ---");

//Declaração de variáveis
int idade, idade_aux, menor_idade = 0, maior_idade = 0;

for (int i = 1; i <= 10; i++)
{
    do
    {
        Console.WriteLine("\nDigite a sua idade");
        do
        {
            Console.Write($"{i}ª pessoa: ");
            idade = int.Parse(Console.ReadLine());
            idade_aux = idade;

            if (idade_aux < 0 || idade_aux > 100)
            {
                Console.WriteLine("\nNúmero Inválido");
                Console.WriteLine("\nDigite Novamente");
            }

        } while (idade_aux < 0 || idade_aux > 100);

        if (idade_aux < 18)
            menor_idade += 1;
        else
            maior_idade += 1;

    } while (idade_aux < 0 && idade_aux > 100);
}
Console.WriteLine("\nResultado Final:");
Console.WriteLine($"Maiores de Idade: {maior_idade}");
Console.WriteLine($"Menores de Idade: {menor_idade}");

//Final do Programa
Console.WriteLine("\nAperte ENTER para encerrar...");
Console.ReadKey();