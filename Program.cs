namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Animal("Dog", "Doberman", "Black", 8);
            
            Console.WriteLine(animal1.GetDetails());
        }
    }
}   