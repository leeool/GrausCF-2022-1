Console.Write("Entre com a temperatura em °F: ");
double F = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\n{F}°F equivalem a: {(F - 32) / 1.8:N2}°C");