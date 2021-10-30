int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

    //инд-с массива  0  1    2   3  4    5   6   7  8
    int[] array = { 11, 121, 31, 41, 15, 61, 17, 18, 19 }; //так мы задаем массив
    //array[0] = 12; //так можно обратиться к массиву и записать в него значение
    //Console.WriteLine(array[4]); // как можно обратиться к массиву по индексу и получить значение этого элемента

    int max = Max(
        Max(array[0], array[1], array[2]),
        Max(array[3], array[4], array[5]),
        Max(array[6], array[7], array[8])
    );
Console.WriteLine(max);


