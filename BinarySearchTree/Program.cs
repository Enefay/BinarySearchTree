using BinarySearchTree.Model;

Tree tree = new Tree();
string input;

Console.WriteLine("Çıkmak için '-'");

while (true)
{
    Console.Write("Bir sayı girin: ");
    input = Console.ReadLine();

    if (input == "-")
    {
        break;
    }

    if (int.TryParse(input, out int value))
    {
        tree.Add(value);
    }
    else
    {
        Console.WriteLine("Geçerli bir sayı girin.");
    }
}

Console.WriteLine("Sonland,.");

Console.ReadKey();


