using static System.Console;
Clear();

Write("Введите координату X первой точки: ");
int.TryParse(ReadLine(), out int ax);
Write("Введите координату Y первой точки: ");
int.TryParse(ReadLine(), out int ay);
Write("Введите координату Z первой точки: ");
int.TryParse(ReadLine(), out int az);
Write("Введите координату X второй точки: ");
int.TryParse(ReadLine(), out int bx);
Write("Введите координату Y второй точки: ");
int.TryParse(ReadLine(), out int by);
Write("Введите координату Z второй точки: ");
int.TryParse(ReadLine(), out int bz);

int A = bx - ax;
int B = by - ay;
int C = az - bz;

double length = Math.Sqrt(A * A + B * B + C * C);
WriteLine($"Длинна отрезка {length:f2}");
