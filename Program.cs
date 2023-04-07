//Converta uma temperatura digitada pelo usuário em °F para °C.

double tempF;
double tempC;

Console.WriteLine("---Conversor de °F para °C\n");

Console.Write("Digite a temperatura em °C: ");
tempC = Convert.ToDouble(Console.ReadLine()!);

tempF = tempC * 1.8 + 32;

Console.WriteLine($"\n{tempC}°C equivalem a {tempF}°F");
