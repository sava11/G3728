System.Random rnd=new System.Random();
int num=rnd.Next(100,1000);
int n1=num/100;
int n2=num%10;
Console.WriteLine(n1*10+n2);
