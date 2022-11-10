﻿// Имеется одномерный массив array из n элементов. 
//Требуется найти элемент массива, равный find.

//1.Установить счетчик index в позицию 0.
//2. Если array[index]=find, алгоритм завершил работу успешно.
//3. Увеличить index на 1(перейти к след элементу массива).
//4. Если index<n, то перейти к шагу 2.
//В противном случае алгоритм завершил работу безуспешно.

//записываем массив 
int []array={1, 4, 12, 31, 4, 15, 16, 17, 4, 18};

//определяем его длину(кол-во элементов)
int n=array.Length;

//придумали параметры для find (найдем элемент массива, равный 4)
int find=4;
//начинаем с первого элемента массива с индексом 0
int index=0;

while(index<n)
{
    //если значение проверяемого элемента равно 4
    if(array[index]==find)
    {
        //выводим индекс этого элемента
        Console.WriteLine(index);
        //если в массиве несколько элементов с одинаковым значением, 
        //этот код покажет индексы всех таких элементов.
        //чтобы это исправить - добавим новый оператор - break 
        //принудительное прерывание алгоритма при нахождении первого find
        break;
    }
    //переходим к след элементу массива
    index++;
}

