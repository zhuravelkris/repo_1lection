// // Нарисовать квадраты 


// //                      20        10
// void DrawRectangle(int posX, int posY, int width, int height)
// {
//     int raw = 0;
//     while(raw < height){
//     Console.SetCursorPosition(posX, posY+ raw);
//     int count = 0;
//     while(count < width)
//     {
//         Console.Write("+");
//         count++;
//     }
//     raw++;
//     }
// }

// DrawRectangle(5, 3, 9, 4);


// Нужно написать программу решения квадратных уравнений

//  Есть три вида квадратных уравнений - без корней, с одним корнем, с 2 корнями
// Чтобы выяснить, сколько корней в уравнении, нужно найти дискриминант
// d = b^2 - 4ac
// если d < 0 - корней нет
// если d = 0  - один корень
// если d > 0 - 2 различных корня

// Ax^2 + Bx + c = 0
// 1x^2 - 2x + 6 = 0

(double, double) Solve(double a, double b, double c) // берем код с частным решением и с помощью метода преобразуем в общее
{
    double d = b * b - 4 * a * c;
    // Console.Write("Дискриминант равен ");
    // Console.WriteLine(d);

    if (d < 0)
    {
        return(double.NaN, double.NaN);
        //Console.WriteLine("Действительных корней нет");
    }
    else
    {
        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
        return (x1,x2);

    //     Console.WriteLine(x1);
    //     Console.WriteLine(x2);

    }
    // Console.WriteLine();

}

(double, double) roots =  Solve(1, -7, 6); Console.WriteLine(roots);

roots = Solve(1, 0, 6);Console.WriteLine(roots);
roots = Solve(1,0,-4); Console.WriteLine(roots);
roots = Solve(1,2,-4);Console.WriteLine(roots);
