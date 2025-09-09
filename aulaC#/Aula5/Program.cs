using System;
using Aula5;

List<Pet> animais = new();


while (true)
{

    Pet pet = new();

    Console.WriteLine("Nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine("Idade: ");
    double idade = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Macho? ");
    bool macho = Convert.ToBoolean(Console.ReadLine());


    pet.Nome = nome;
    pet.Idade = idade;
    pet.Macho = macho;

    animais.Add(pet);

    Console.WriteLine("Mais um bichinho?");
    string resp = Console.ReadLine();


    if (resp == "N")
    {
        break;
    }
}


foreach (Pet animal in animais)
{
    Console.WriteLine(animal.Nome);
    Console.WriteLine(animal.Idade);
    Console.WriteLine(animal.Macho);
}

Console.ReadKey();