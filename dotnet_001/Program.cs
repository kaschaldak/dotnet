//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
//Например:
//● 4 -> 16
//● -3 -> 9
//● -7 -> 
Console.WriteLine("Enter number: ");
string enterNum = Console.ReadLine();
int num = Convert.ToInt32(enterNum);

int sqr = num * num;

Console.WriteLine($"sqr = {sqr} ");    
