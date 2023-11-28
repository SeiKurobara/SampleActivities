namespace SampleActivities;

internal class Program
{
    SampleClass sampleClass = new SampleClass();
    // Fields
    // Expression-Embodied Method
    // Local Methods
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(MultiplyBy10(2));

        CubeRoot(10);
    }

    // Expression-Embodied Method
    // the {} and return is Replaced by =>
    static int MultiplyBy10(int x) => x * 10 ;
    // Expression-Embodied Method

    // Local Methods
    // You can Declare a Method inside a Method(Method-ception)
    static void CubeRoot(int cubeCounts)
    {
        for (int i = 1; i < cubeCounts; i++)
        {
            Console.Write(CubeCompute(i) + " ");
        }
        int CubeCompute (int x) => x * x * x;
    }

    // Local Methods
}

// Fields
// a Field is a Variable that is a member of a Class/struct
class SampleClass
{
    string name = "Melanio";
    public int age = 23;

    
}
// Fields

