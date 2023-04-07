//Converta uma temperatura digitada pelo usuário em °F para °C.

double tempF;
double tempC;

Console.WriteLine("---Conversor de °F para °C\n");

Console.Write("Digite a temperatura em °F: ");
tempF = Convert.ToDouble(Console.ReadLine()!);

tempC = tempF * 1.8 + 32;

Console.WriteLine($"\n{tempF}°F equivalem a {tempC}°C");
