/* Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
пользователь вводит число элементов в массиве и минимальное, и максимальное значение . надо заполнить массив рандоными данными от минимального до максимального значение .И важное уточнениее , делать все в методе который возвращает массив
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

//условия задачи не понятны

/*Вариант1. Напишите программу, которая задаёт массив из введенного числа и выводит массив на экран.
192 -> [1, 9, 2]
1679425 -> [1, 6, 7, 9, 4, 2, 5]*/
void PrintArray(int[] array){
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i]);
    if (i < array.Length - 1) Console.Write(", ");
  }
  Console.WriteLine("]");
}
int[] FormArray(int num){
  int length = num.ToString().Length;
  int[] array = new int[length];
  for (int i = length-1; num > 0; i--)
  {
    array[i] = num % 10;
    num = num / 10;
  }
  return array;
}

Console.WriteLine("Вариант1. Введите целое число из которого сформируется массив:");
int num = int.Parse(Console.ReadLine());

int[] array = FormArray(num);
PrintArray(array);

/*Вариант2. Пользователь вводит число элементов в массиве, минимальное и максимальное значение. Надо заполнить массив рандомными данными от минимального до максимального значение.
3, 1, 5 -> [4, 5, 1]
6, 1, 5 -> [3, 1, 5, 2, 2, 1]
8, 2, 4 -> [3, 2, 4, 4, 3, 2, 2, 4]
*/
int[] GenerateArray(int amount, int minNum, int maxNum){
  int[] array = new int[amount];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(minNum, maxNum+1);
  }
  return array;
}

Console.WriteLine("Вариант2. Введите число элементов в массиве, минимальное и максимальное значение:");
int amount = int.Parse(Console.ReadLine());
int minNum = int.Parse(Console.ReadLine());
int maxNum = int.Parse(Console.ReadLine());

int[] array2 = GenerateArray(amount, minNum, maxNum);
PrintArray(array2);