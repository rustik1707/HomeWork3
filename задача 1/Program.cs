/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */


int Getnumber(string message)

{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
       if (int.TryParse(Console.ReadLine(), out result) && result>9999 && result< 100000)
       {
        isCorrect = true;
       }
       else
       {
        Console.WriteLine("Ввели не пятизначное число");
       }
    }
return result;
}

int num = Getnumber("введите пятизначное число");
 
 if (num/10000 == num % 10 && (num/1000)%10 == (num/10)%10){ 
    Console.WriteLine("yes");} 
else{
   Console.WriteLine("no"); }
