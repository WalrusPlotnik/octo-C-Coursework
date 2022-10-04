# Итоговая проверочная работа

## Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 

Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*

*[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]*

*[“1234”, “1567”, “-2”, “computer science”] → [“-2”]*

*[“Russia”, “Denmark”, “Kazan”] → []*

## Решение

Задача решена посредством использования трёх функций:

* KeyboardArray: запрашивает у пользователя число, определяющее количество элементов (строк ) в массиве, после чего принимает различные знаки в качестве значения элемента. Конец элемента - enter.
*  ModifiedArray: создаёт ещё новый массив и, взяв за ограничение количества повторов  длину пользовательского массива, заполняет этот новый массив теми элементами пользовательского массива, длина значений которых меньше или равна трём.
* ShowMyArray: выводит массив на экран.

 ## Графическое представление алгоритма:
 ![графический файл с алгоритмом](AlgoritmCoursework.drawio(1).png)

 ## Содержимое репозитория:

* AlgoritmCoursework.drawio(1).png: блок-схема алгоритма.
* README.md: текстовое описание решения.
* Program.cs: код программы на языке C#.
