using Decorator;

class Program
{
    static void Main(string[] args)
    {
        Coffee myCoffee = new SimpleCoffee();
        Console.WriteLine($"{myCoffee.GetDescription()} kosztuje {myCoffee.GetCost()} zł");

        myCoffee = new MilkDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} kosztuje {myCoffee.GetCost()} zł");

        myCoffee = new SugarDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} kosztuje {myCoffee.GetCost()} zł");

        myCoffee = new ChocolateDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} kosztuje {myCoffee.GetCost()} zł");
    }
}