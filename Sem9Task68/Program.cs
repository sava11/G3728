// функция Аккермана
uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}
// ввод чисел
uint InputNum(string msg = "")
{
    Console.Write(msg);
    return uint.Parse(Console.ReadLine() ?? "0");
}
Console.Write("Результат: "+A(InputNum("Введите число a: "),InputNum("Введите число b: ")).ToString());