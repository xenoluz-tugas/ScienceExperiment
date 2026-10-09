int temp = 0;
bool isTempValid = -50 < temp && temp > 50;

do
{
    Console.Write("Input the temparature (°C): ");
    temp = int.Parse(Console.ReadLine());

    if (!isTempValid)
    {
        Console.WriteLine("Invalid input. Temparature must be between -50°C and 150°C");
    }
} while (!isTempValid);

string category = temp switch
{
    <0 => "Freezing",
    <30 => "Normal",
    <100 => "Hot",
    >100 => "Extremely Hot",
    _ => "OUTOFBOUND"
};

Console.WriteLine(@$"
Temparature recorded {temp}°C
Category: {category}
");