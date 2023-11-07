namespace SampleActivities
{
    internal class Program
    {
        // Switch Statement In Dept
        static void Main(string[] args)
        {
            CardNumber(14);
            CardNumberIdentifier(14);
            DifferentTypes("Melares");
            DifferentTypes(100);
            DifferentTypes('M');
            DifferentTypes(true);
            SwitchExpression(14);
            SwitchTuplePattern(10, "Hearts");
        }

        // goto case, goto default
        // Other Jump statement in switch return, throw, continue, goto
        static void CardNumber(int cardNumber)
        {
            switch (cardNumber)
            {
                case 11:
                    Console.WriteLine("Jack");
                    break; // Jumps to the end of the Switch Statement
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 13:
                    Console.WriteLine("King");
                    break;
                case -1:
                    // new
                    goto case 12; // Jumps to another case Clause
                case > 13:
                    goto default; // Jumps to default clause
                case < -1:
                    goto default;

                default:
                    if (cardNumber < -1 || cardNumber > 13)
                        Console.WriteLine("Invalid Card");
                    else
                    Console.WriteLine($"Card Number: {cardNumber}");

                    break;
            }
        }

        static void CardNumberIdentifier(int cardNumber) {
            switch (cardNumber)
            {
                case < 11:
                    Console.WriteLine("Number Cards");
                    break;
                    // Multiple case can have a same value
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("Face Cards");
                    break;

                default:
                    Console.WriteLine("Invalid Cards");
                    break;
            }
        }

        // You can use objects to use othe types
        static void DifferentTypes(object x)
        {
            switch (x)
            {
                case string s:
                    Console.WriteLine("The value is a String " + s);
                    break;
                case int i:
                    Console.WriteLine("The value is a Int " + i);
                    break;
                case char c:
                    Console.WriteLine("The value is a Character " + c);
                    break;
                case bool b:
                    Console.WriteLine("The value is a Boolean " + b);
                    break;
                default:
                    break;
            }
        }

        // Switch as an Expression
        static void SwitchExpression(int cardNumber)
        {
            string cardName = cardNumber switch
            {
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                > 1 and < 11 => "Number Cards", // can only use Logical and , cant use Logical or
                _ => "Invalid Cards" // _ is like a Default for a Normal Switch
            };

            Console.WriteLine(cardName);

        }

        static void SwitchTuplePattern(int cardNumber,string suite)
        {
            // Tuple can pass multiple values to a method through a single parameter
            string cardName = (cardNumber, suite) switch
            {
                (13,"Spades") => "King of Spades",
                (12, "Spades") => "Queen of Spades",
                (11, "Spades") => "Jack of Spades",
                ( >= 1 and <= 10, "Spades") => $"Spades {cardNumber}",
                (13, "Hearts") => "King of Hearts",
                (12, "Hearts") => "Queen of Hearts",
                (11, "Hearts") => "Jack of Hearts",
                ( >= 1 and <= 10, "Hearts") => $"Hearts {cardNumber}",
                (13, "Clover") => "King of Clover",
                (12, "Clover") => "Queen of Clover",
                (11, "Clover") => "Jack of Clover",
                ( >= 1 and <= 10, "Clover") => $"Clover {cardNumber}",
                (13, "Diamond") => "King of Diamond",
                (12, "Diamond") => "Queen of Diamond",
                (11, "Diamond") => "Jack of Diamond",
                ( >= 1 and <= 10, "Diamond") => $"Diamond {cardNumber}",

                (_, _) => "Invalid Cards",



            };

            Console.WriteLine(cardName);
        }


    }
}