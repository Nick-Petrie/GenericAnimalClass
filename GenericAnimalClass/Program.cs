using System;

public class Animal<T>
{
    public T data;
    public Animal(T data)
    {
        this.data = data;
    }
    public T GetAnimal()
    {
        return data;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal<string> animalName = new Animal<string>("Bald Eagle");
        Animal<string> animalHabitat = new Animal<string>("Within 2.5 miles of water");
        Animal<bool> endangered = new Animal<bool>(false);
        Animal<bool> extinct = new Animal<bool>(false);
        Animal<int> averageLifespan = new Animal<int>(25);

        Console.WriteLine("Animal Name: " + animalName.GetAnimal());
        Console.WriteLine("Animal Habitat: " + animalHabitat.GetAnimal());
        Console.WriteLine("Endangered: " + endangered.GetAnimal());
        Console.WriteLine("Extinct: " + extinct.GetAnimal());
        Console.WriteLine("Average Lifespan: " + averageLifespan.GetAnimal() + " years");
    }
}