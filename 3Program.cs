// Task # 3. Задать номер четверти, показать диапазоны для возможных координат

int number = new Random().Next(1, 5);
string range = "";
string num = "";

if (number == 1) range = "x > 0, y > 0";
else if (number == 2) range = "x < 0, y > ";
else if (number == 3) range = "x < 0, y < 0";
else range = "x > 0, y < 0";

System.Console.WriteLine($"Для {number}-й четверти диапазон для возможных координат ( {range} )");
System.Console.WriteLine();