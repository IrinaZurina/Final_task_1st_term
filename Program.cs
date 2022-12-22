// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Console.Clear();

Console.Write("Сколько элементов вы хотите проверить? Введите целое число и нажмите enter: ");
int userNum = int.Parse(Console.ReadLine() ?? "");   // запрашиваем у пользователя, сколько элементов он хочет ввести

string[] userArray = FillArray(userNum);   // заполняем массив пользовательскими значениями через вызов метода

string[] finalArray = DeleteLongElements(userArray, 3);

Console.WriteLine(finalArray);

// метод для заполнения массива длиной n пользовательскими значениями
string[] FillArray(int n)
{
    string[] filledArray = new string[n];
    for (int i = 0; i < n; i++)
    {
        filledArray[i] = Console.ReadLine() ?? "";
    }
    return filledArray;
}


// метод для получения нового массива, содержащего элементы исходного массива длиной не более трех символов
string[] DeleteLongElements(string[] inArray, int num)
{

}