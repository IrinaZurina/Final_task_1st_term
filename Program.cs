// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Console.Clear();

Console.Write("Сколько элементов вы хотите проверить? Введите целое число и нажмите enter: ");
int userNum = int.Parse(Console.ReadLine() ?? "");   // запрашиваем у пользователя, сколько элементов он хочет ввести

string[] userArray = FillArray(userNum);   // заполняем массив пользовательскими значениями через вызов метода

string[] finalArray = DeleteLongElements(userArray, 3);   // Через метод создаем новый массив с элементами длиной не более 3 символов

Console.WriteLine($"{String.Join(" ", userArray)}  -> {String.Join(" ", finalArray)}");

// метод для заполнения массива длиной n пользовательскими значениями
string[] FillArray(int n)
{
    string[] filledArray = new string[n];
    Console.WriteLine($"Введите {n} элемента/ов:");
    for (int i = 0; i < n; i++) filledArray[i] = Console.ReadLine() ?? "";    
    return filledArray;
}

// метод для получения нового массива, содержащего элементы исходного массива длиной не более трех символов
string[] DeleteLongElements(string[] inArray, int num)
{
    int count = 0;   // счетчик для определения кол-ва элементов длиной не более трех символов
    int[] positions = new int[inArray.Length];   // массив с индексами элементов не более трех символов
    for (int i = 0; i < inArray.Length; i++)   // цикл для подсчета кол-ва элементов длиной не более трех символов и запоминания их индексов
    {
        if (inArray[i].Length <= num) 
        {
            positions[count] = i;
            count++;
        }
    }

    string[] resultArray = new string[count];   // создаем новый массив длиной count
    for (int j = 0; j < count; j++) resultArray[j] = inArray[positions[j]];   // записываем в новый массив выбранные элементы
    
    return resultArray;
}

