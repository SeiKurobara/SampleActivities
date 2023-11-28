namespace SampleActivities;

internal class Program
{

    // Fields
    // Expression-Embodied Method
    // Local Methods
    // Constructor Overload
    // Deconstructor
    // Simple way of Writing a Constructor
    static void Main(string[] args)
    {
        SampleClass sampleClass = new SampleClass("melanio");
        SampleClass sampleClass2 = new SampleClass("melanio2",23,false);
        var sampleClass3 = new SampleClass("melanio2", 23, false);
        Console.WriteLine("Hello, World!");
        Console.WriteLine(MultiplyBy10(2));
        Console.WriteLine(sampleClass.name);
        Console.WriteLine(String.Concat(sampleClass2.name, sampleClass2.age, sampleClass2.isDead));
        CubeRoot(10);
        Console.WriteLine();

        // Deconstructor
        // The Deconstructor takes the values from the fields of sampleClass3 and set it to a Variable
        // You can also use the discard(_) if you don't want to retrieve an individual data
        var (personName,  personAge,  personIsDead) = sampleClass3;
        Console.WriteLine($"{personName} {personAge} {personIsDead}");

        var sampleConstructor2 = new SampleConstructor2(2f,2f);

        var (width, height) = sampleConstructor2;

        Console.WriteLine($"{width} {height}");
        // Deconstructor

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
    // Can also be used in a constructor
        int CubeCompute (int x) => x * x * x;
    }

    // Local Methods
}

// Fields
// a Field is a Variable that is a member of a Class/struct
class SampleClass
{
    public string name = "Melanio";
    public int age = 23;
    public bool isDead = false; 

    // Constructor Overload
    // Also known as Constructor Chaining 
    // ": this (expression):" passing the value of the expression to the overloaded constructor

    public SampleClass(string name) { this.name = name; }
    public SampleClass(string name, int age) : this(name) {this.age = age;}
    public SampleClass(string name, int age,bool isDead) : this(name,age) { this.isDead = isDead; }

    // Constructor Overload

    // Deconstructor
    // The Deconstructor is the Opposite of the Constructor
    public void Deconstruct(out string name, out int age, out bool isDead)
    {
        name = this.name;
        age = this.age;
        isDead = this.isDead;
    }


    // Deconstructor
}
// Fields

class SampleConstructor2
{
    public float Width, Height;

    // Simple way of Writing a Constructor
    public SampleConstructor2(float Width, float Height)
    => (this.Width, this.Height) = (Width, Height);
    // Simple way of Writing a Constructor
    public void Deconstruct(out float Width, out float Height)
    {
        Width = this.Width;
        Height = this.Height;
    }
}

