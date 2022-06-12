// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26

int a = 2, b = 9;
int N = 8;
int Fib (int f, int s, int num)
{
    if (num == 0 ) return f;
    if (num==1)return s;
    return Fib(f,s,num-1)+Fib(f,s,num-2);

}
for (int i = 0; i < N; i++)
{
int m = Fib (a,b,i);
Console.Write(m + " ");
}
