// See https://aka.ms/new-console-template for more information
namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = LoadShoppingList();

            while (true)
            {
                Console.WriteLine("Shopping List");
                Console.WriteLine("-------------");
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {shoppingList[i]}");
                }

                Console.WriteLine("\n1. Agregar");
                Console.WriteLine("2. Remover");
                Console.WriteLine("3. Salir");
                Console.Write("\nIngresa tu elección: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Ingresa el nombre: ");
                        string item = Console.ReadLine();
                        shoppingList.Add(item);
                        break;
                    case 2:
                        Console.Write("Ingresa el número: ");
                        int itemNumber = Convert.ToInt32(Console.ReadLine());
                        shoppingList.RemoveAt(itemNumber - 1);
                        break;
                    case 3:
                        SaveShoppingList(shoppingList);
                        return;
                       
                }
            }
        }

        static List<string> LoadShoppingList()
        {
            if (File.Exists("shoppinglist.txt"))
            {
                List<string> shoppingList = new List<string>(File.ReadAllLines("shoppinglist.txt"));
                return shoppingList;
            }
            else
            {
                return new List<string>();
            }
        }

        static void SaveShoppingList(List<string> shoppingList)
        {
            File.WriteAllLines("shoppinglist.txt", shoppingList);
        }
    }
}