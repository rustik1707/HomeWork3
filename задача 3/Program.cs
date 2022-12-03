// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N


int Getnumber(string message)

{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
       if (int.TryParse(Console.ReadLine(), out result) && result>0)
       {
        isCorrect = true;
       }
       else
       {
        Console.WriteLine("Ввели не натуральное число");
       }
    }
return result;
}

int number = Getnumber("введите число:");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i*i*i}, ");

};
