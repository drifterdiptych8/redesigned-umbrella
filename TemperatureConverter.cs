using System;

class TemperatureConverter {
    static void Main() {
        Console.Write("🌡 Enter temperature: ");
        double temp = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Convert to (C/F): ");
        char unit = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (unit == 'C')
            Console.WriteLine($"✅ {temp}°F = {(temp - 32) * 5/9:F2}°C");
        else if (unit == 'F')
            Console.WriteLine($"✅ {temp}°C = {temp * 9/5 + 32:F2}°F");
        else
            Console.WriteLine("❌ Invalid choice!");
    }
}
