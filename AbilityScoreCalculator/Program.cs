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

}

static double ReadDouble(double lastUsedValue, string prompt)
{

}