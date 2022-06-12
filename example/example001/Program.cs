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
