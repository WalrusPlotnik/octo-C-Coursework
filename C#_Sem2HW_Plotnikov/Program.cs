// Семинар 2 C# ДЗ Плотников
// Напишите программу, которая принимает на вход 3-хзначное число
// и на выходе показывает вторую цифру числа

// блок придумывания названия функции
int ShowMeNumber(){
   // блок девелоперского клавиатурного ввода
 //Console.WriteLine("Введите тестовое число: ");
 //int threedig = Convert.ToInt32(Console.ReadLine());
   // блок генерации исходных данных
   int threedig = new Random().Next(100,1000);
   // блок вычислений
    threedig = threedig / 10;
    threedig = threedig % 10;
    return threedig;
}
// блок обращения к функции
int num2th = ShowMeNumber();
// блок вывода
Console.WriteLine ("Количество десятков в числе: " + num2th);



/*/ Напишите программу, которая выводит 3-ю цифру заданного числа,
// либо сообщает, что третьей цифры нет.

// блок придумывания названия функции
string PrintMeNumberOrNot(){
// блок ввода    
  Console.WriteLine("Введите число: ");
  string dig = (Console.ReadLine());
// блок вычислений  
if (dig.Length > 2)
   Console.WriteLine ("Третья цифра вашего числа: " + dig[2]);
    else
    Console.WriteLine ("В вашем числе нет третьей цифры." );
   return dig; 
   }
// блок обращения к функции
string dig = PrintMeNumberOrNot();



// Напишите программу, на вход принимает одну цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// блок придумывания названия функции
void RelaxOrWork (){
// блок ввода   
Console.WriteLine("Введите номер дня недели: ");
int daynumber = Convert.ToInt32(Console.ReadLine()); 
// блок контроля входного данного
if(daynumber < 1 || daynumber > 7){
   Console.WriteLine("Такой день недели в базе не обнаружен."); 
// блок сравнений и вывода
}
        else 
        if(daynumber > 5){
        Console.WriteLine("Ура! Это выходной день."); 
}
        else 
        Console.WriteLine("К сожалению, это не выходной день. Придётся поработать."); 
}
// блок обращения к функции
RelaxOrWork();


*/