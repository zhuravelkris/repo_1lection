// //Вид 1  методы, которые ничего не принимают, ничего не возвращают
// void Method() //здесь аргументов в скобках нет
// {
//     Console.Writeline("Автор...");
// }
// // Method(); вызов метода


// Вид 2 методы, которые что-то принимают, ничего не возвращают

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method21(msg: "Текст сообщения");    // вызов метода
// или вот так

// void Method21(string msg, int count)
// {int i = 0;
// while(i < count)
// {
//     Console.WriteLine(msg);
//     i++;
// }
// }
// // Method21(msg: "Текст", count: 4);
// // или так
// Method21(count: 4, msg: "новый текст");


// Вид 3 Ничего не принимают, что-то возвращают

// int Method3()

// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// Вид4 Методы, которые что-то принимают и что-то возвращают

// string Method4(int count, string text) //строку text будем компоновать count раз 
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// Оператор цикла for 

// string Method4(int count, string text) //строку text будем компоновать count раз 
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// Для того, чтобы понять, как использовать цикл for, рассмотрим задачу вывода 
// на экран таблицы умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

//НОВАЯ ЗАДАЧА

//Дан текст, в котором нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить на большие "К",
//а большие "С" заменить на маленькие "с"

// string text = " - Я думаю,  - сказал князь, улыбась, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// //string s = "qwerty"
// //            012345
// // s[3] // r - обратились к третьему символу строки по идентификатору (номеру символа в строке)


// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length; //заводим переменную равную длине текста
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();


// НОВАЯ ЗАДАЧА
// Дан массив из чисел, необходимо отсортировать элемнты массива по возрастанию 

int [] arr = {1,5,4,3,2,6,7,1,1};

//напишем метод, который будет выводить массив на экран, сделаем это 
// несколькими способами

void PrintArray(int[]array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// теперь пишем метод, который будет упорядочивать массив

void SelectionSort( int[] array)
{
    for (int i = 0; i < array.Length  - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j; 
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}



PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);