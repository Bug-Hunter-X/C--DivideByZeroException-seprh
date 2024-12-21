public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod(int y)
    {
        int x = 5;
        if (y == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return;
        }
        int z = x / y; 
        Console.WriteLine(z);
    }
}