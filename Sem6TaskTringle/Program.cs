int circle(int a, int mn, int mx)
{
    return Math.Abs(a) % (mn + mx) + mn;
}

double GetArea(double[][] pol)
{
    double area = 0;
    int len = pol.GetLength(0);
    for (int i = 0; i < len; i++){
        // Console.WriteLine(pol[i][0] + " " + pol[i][1]);
        area += pol[i][0] * pol[circle(i + 1, 0, len)][1] - pol[circle(i + 1, 0, len)][0] * pol[i][1];}
    return Math.Abs(area);
}
double[] calc(double k1, double b1, double k2, double b2)
{
    if ((k1 != k2) && (b1 != b2))
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        return new double[2] { x, y };
    }
    else
    {
        return new double[0] { };
    }
}
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void checkPolygon(double[][]arr){
    bool exit=false;
    double[]empty=new double[0]{};
    foreach(var i in arr){
        if (i.Length==0){
            Console.WriteLine("одна или несколько линий не пересекаются");
            exit=true;
            break;
        }
    }
    if (exit==false)
        Console.WriteLine("Площадь стриугольника, образованного тремя линиями: "+GetArea(arr));
}
int k1 = InputNum("Введите k1:");
int b1 = InputNum("Введите b1:");
int k2 = InputNum("Введите k2:");
int b2 = InputNum("Введите b2:");
int k3 = InputNum("Введите k3:");
int b3 = InputNum("Введите b3:");
double[][] poly = new double[3][];
poly[0] = calc(Convert.ToDouble(k1), Convert.ToDouble(b1), Convert.ToDouble(k2), Convert.ToDouble(b2));
poly[1] = calc(Convert.ToDouble(k3), Convert.ToDouble(b3), Convert.ToDouble(k2), Convert.ToDouble(b2));
poly[2] = calc(Convert.ToDouble(k1), Convert.ToDouble(b1), Convert.ToDouble(k3), Convert.ToDouble(b3));
checkPolygon(poly);

