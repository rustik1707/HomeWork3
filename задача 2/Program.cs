/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int Getnumber(string message)

{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
       if (int.TryParse(Console.ReadLine(), out result))
       {
        isCorrect = true;
       }
       else
       {
        Console.WriteLine("Ввели не координаты");
       }
    }
return result;
}

int x1 = Getnumber("введите х1");
int y1 = Getnumber("введите y1");
int z1 = Getnumber("введите z1");
int x2 = Getnumber("введите х2");
int y2 = Getnumber("введите y2");
int z2 = Getnumber("введите z2");

double data1 = Math.Pow((x2-x1),2);
double data2 = Math.Pow((y2-y1),2);
double data3 = Math.Pow((z2-z1),2);

double distance = Math.Sqrt(data1+data2+data3);

Console.WriteLine($"Расстояние между точками: {distance}");