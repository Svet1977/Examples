// использование массива при написании кода
//max из массива из 9 чисел


int Max(int ard1, int ard2,int ard3)
{
    int result = ard1;
//result - внутренний результат, в нем будет храниться наш max
    if(ard2>result) result=ard2;
    if(ard3>result) result=ard3;
    return result;
    // return  result - возвращение методом результата
}

//вводим массив
int [] array={11, 21, 31, 41, 15, 61, 17, 18, 19};

//вычисляем max элемент массива, вызывая функцию Max в каждой тройке
int max=Max(Max(array[0],array[1],array[2]),
            Max(array[3],array[4],array[5]),  
            Max(array[6],array[7],array[8]));     

//выводим результат
Console.WriteLine(max);