/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

void Exponentiate(int a, int b){
  int result = a;
  for (int i = 1; i < b; i++)  result = result * a;
Console.WriteLine(result);
}

Console.WriteLine("Введите два числа: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

Exponentiate(A, B);