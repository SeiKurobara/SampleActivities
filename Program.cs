using System.Runtime.CompilerServices;
using static SampleActivities.SampleActivitiesInner.sampleClass;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SampleActivities;

internal class Program
{
    // Namespaces
    // Classes
    // Ref Modifier
    // Out Modifier
    // Params Modifier
    // Null Coalescing Operator

    static void Main(string[] args)
    {
        // Ref Modifier
        int refModif = 1;
        RefSample(ref refModif);
        WriteLine(refModif);
        // Ref Modifier

        // Out Modifier
        int out1,out2,outSum;
        int out3, out4;
        OutSample(out out1,out out2,out outSum);
        WriteLine($"out1 value is {out1}, out2 value is {out2},  and their sum is {outSum}");
        //You can use a Discard(_) if you don't want to received a value using an out modifier
        OutSample(out out3, out out4, out _);
        WriteLine($"out3 value is {out3}, out4 value is {out4},  and their sum is  ");
        // Out Modifier

        // Params Modifier
        int paramSums = 0;
        ParamsSample(ref paramSums,new int[] { 1, 2, 3, 4 });

        WriteLine($"The output for paramSums is {paramSums}");
        // Params Modifier

        // Null Coalescing Operator
        // ?? Read as if the operand to the left is null then give me an another value;
        string nullSample = null;
        string nullCheck = nullSample ?? "Its null but it gave me this value";

        WriteLine(nullCheck);

        // Null Coalescing Assignment operator
        string someDefault = "someDefault";
        string myVariable = null;
        myVariable ??= someDefault;
        // is equivalent to 
        //if (myVariable == null) myVariable = someDefault;

        WriteLine(myVariable);
        // Null Coalescing Operator

        WriteLine("Hello, World!");
        sampleMethod();
    }
    // Ref Modifier
    // refModif and ParamRefModif refers to the same Memory Locations.
    static void RefSample(ref int ParamRefModif)
    {
        ParamRefModif++;
    }
    // Ref Modifier

    // Out Modifier

    // out Modifier is used to return more than 1 value in a method

    // An out argument is like a ref argument except for the following:
    //
    //• It need not be assigned before going into the function.
    //• It must be assigned before it comes out of the function.

    static void OutSample(out int paramOut1,out int paramOut2,out int paramSum )
    {
        paramOut1 = 10;
        paramOut2 = 20;
        paramSum = paramOut1 + paramOut2;
    }
    // Out Modifier

    // Params Modifier

    // The params modifier should be on the last parameter
    // The parameter type must be declared as a single dimensional array
    static void ParamsSample(ref int paramParamsSum, params int[] paramParams) 
    {
        for (int i = 0; i < paramParams.Length; i++)
        {
            paramParamsSum += paramParams[i];
        }
    }
    // Params Modifier
}

class Sample
{
    // Fields
    //Fields allow the following modifiers:
    //Static modifier static
    //Access modifiers public internal private protected
    //Inheritance modifier new
    //Unsafe code modifier unsafe
    //Read-only modifier readonly
    //Threading modifier volatile

    string name = "Melanio";
    int age = 23;
}

public class InOutsRefs {

    

}
