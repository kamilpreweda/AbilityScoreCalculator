using AbilityScoreCalculator;

Calculator calculator = new Calculator();
while (true)
{
    calculator.RollResult = ReadInt(calculator.RollResult, "Początkowy rzut 4d6");
    calculator.DivideBy = ReadDouble(calculator.DivideBy, "Dzielone przez");
    calculator.AddAmount = ReadInt(calculator.AddAmount, "Dodawana wartość");
    calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
    calculator.CalculateAbilityScore();
    Console.WriteLine($"Obliczone punkty umiejętności: {calculator.Score}");
    Console.WriteLine("Wciśnij 'Q' aby zakończyć, lub inny klawisz, aby kontynuować");
    char keyChar = Console.ReadKey(true).KeyChar;
    if ((keyChar == 'Q') || (keyChar == 'q')) return;

    
}


static int ReadInt(int lastUsedValue, string prompt)
{
    Console.WriteLine(prompt + " [Wartość domyślna: " + lastUsedValue.ToString() + " ]");
    Console.Write($"Wpisz {prompt}: ");
    bool IsuserInputValid = int.TryParse(Console.ReadLine(), out int userInput);
    if (IsuserInputValid)
    {
        Console.WriteLine($"Użycie wartości: {userInput}");
        return userInput;
    }else
    {
        Console.WriteLine($"Użycie wartości domyślnej: {lastUsedValue}");
        return lastUsedValue;
    }
    
}

static double ReadDouble(double lastUsedValue, string prompt)
{
    Console.WriteLine(prompt + " [Wartość domyślna: " + lastUsedValue.ToString() + " ]");
    Console.Write($"Wpisz {prompt}: ");
    bool IsuserInputValid = double.TryParse(Console.ReadLine(), out double userInput);
    if (IsuserInputValid)
    {
        Console.WriteLine($"Użycie wartości: {userInput}");
        return userInput;
    }
    else
    {
        Console.WriteLine($"Użycie wartości domyślnej: {lastUsedValue}");
        return lastUsedValue;
    }
}