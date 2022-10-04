// **********************************************************************************************************************************
// ############# C# Итоговая проверочная работа, Плотников ##########################################################################
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

// получаем от пользователя размер массива, выделяем переменную под результат
/*
Console.Write("Сколько элементов массива вы собираетесь ввести? "); 
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];

// тело функции создания массива через клавиатурный ввод
string[] KeyboardArray(int size){
    // в цикле получаем на вход значения элементов массива
    for (int i = 0; i < size; i++){
     Console.WriteLine("Введите элемент массива: ");
         array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

// тело функции, демонстрирующей массив
void ShowMyArray(string[] array){
Console.Write("[ ");
for (int i = 0; i < size; i++){
          Console.Write($"{array[i]} ");
    }
Console.Write("]");
}

// тело функции создания второго массива через наполнение элементами, подходящими по условию
string[] ModifiedArray(string[] array, int size){
    string[] arrayM = new string[size];
    int limit = 3;
    int j = 0;
    for (int i = 0; i < size; i++){
        if (array[i].Length <= limit){
            arrayM[j] = array[i];
            j++;    
        }
    }
    return arrayM;
}

// вызываем функцию, создающую массив 
KeyboardArray(size); 
// вызываем функцию, демонстрирующую массив
Console.WriteLine(" ");
Console.WriteLine("Вoт ваш массив: ");
ShowMyArray(array);
Console.WriteLine(" ");
Console.WriteLine("А вот массив из элементов длиной три и меньше вашего массива:");
// вызываем функцию демонстрации для второго массива
ShowMyArray (ModifiedArray(array, size));

*/
