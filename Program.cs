//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] array = GetCoordinates("Введите значение координат: ");
double CoordX = GetCoordinatesX(array[0]);
double CoordY = GetCoordinatesY(array[1]);

Console.Write($"b1 = {array[0]}, k1 = {array[1]}, b2 = {array[2]}, k2 = {array[3]} -> ({String.Join(", ", CoordX)}; {String.Join(", ", CoordY)})");

double[] GetCoordinates(string message)
{
    double[] result = new double[4];
    for (int i = 0; i < 4; i++)
    {
        int NumberFromUser = GetNumberFromUser("Ошибка ввода! ");
        int GetNumberFromUser(string errorMessage)
        {
            while (true)
            {
                Console.Write(message);
                bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
                if (isCorrect)
                    return userNumber;
                Console.WriteLine(errorMessage);
            }
        }
        result[i] = NumberFromUser;
    }
    return result;
}

double GetCoordinatesX(double x)
{
    x = (array[0] - array[2]) / ((array[1] - array[3]) * -1);
    return x;
}

double GetCoordinatesY(double y)
{
    y = array[3] * CoordX + array[2];
    return y;
}