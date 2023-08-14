// Importação
using System;

// Nasmespace
namespace MeuApp
{
    //Classe principal do Programa
    class Program

    {
        // Função principal do Programa
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse Gamer", 299.97f, EProductType.Product);
            var manutencaoEletrica = new Product (2, "Manutenção elétrica residencial", 500, EProductType.Service);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
            
        }
    }


    struct Product 
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;
        public double PriceInDolar(double dolar) 
        {
            return Price*dolar;
        }
        
    }

    enum EProductType {
        Product = 1,
        Service = 2
    }
}
