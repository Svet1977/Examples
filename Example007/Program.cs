// нахождение max из 9 чисел(тройками) 15, 21, 39, 12, 23, 33, 13, 23, 33.
//                                     а1  b1  c1  a2  b2  c2  a3  b3  c3

// функцию назовем - max, будем работать с целыми числами
//(как на прием,так и на выдачу результата) - поэтому тип аргумента будет int.
// int Max(int)

//это функция нахождения max из трех чисел


int a1=15;
int b1=21;
int c1=39;
int a2=21;
int b2=23;
int c2=33;
int a3=13;
int b3=23;
int c3=33;

int Max(int ard1, int ard2,int ard3)
{
    int result = ard1;
//result - внутренний результат, в нем будет храниться наш max
    if(ard2>result) result=ard2;
    if(ard3>result) result=ard3;
    return result;
    // return result - возвращение методом результата
}

//Применим ее для нахождения max в каждой тройке
int max1=Max(a1, b1, c1);
int max2=Max(a2, b2, c2);
int max3=Max(a3, b3, c3);
//После чего найдем итоговый max
int max=Max(max1, max2, max3);
//можно было записать так int Max=Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);

