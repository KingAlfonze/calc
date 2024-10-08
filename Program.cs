//Console Modifications
Console.Title = "Simple Calculator";
Console.ForegroundColor = ConsoleColor.Cyan;

 do{ 
        double num1 = 0;
        double num2 = 0;
        double result = 0;

        Console.Write("Welcome to Simple Calculator!\n");

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Select an Operation:");
        Console.WriteLine("\t+");
        Console.WriteLine("\t-");
        Console.WriteLine("\t*");
        Console.WriteLine("\t/");
        Console.Write("Selected Operation: ");

        switch (Console.ReadLine())
        {
            case "+":
            result = num1 + num2;
            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            break;

            case "-":
            result = num1 - num2;
            Console.WriteLine($"Your result: {num1} - {num2} = " + result); 
            break;

            case "*":
            result = num1 * num2;
            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            break;
            
            case "/":
            result = num1 / num2;
            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            break;

            default:
            Console.WriteLine("Invalid Operator!");
            break;
        }  
        Console.WriteLine("Do you want to try again? (Y or N?)");
         
   
    }while (Console.ReadLine().ToUpper() == "Y");

Console.WriteLine("Goodbye!");


