// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

Console.Write("input yor day num: ");
string? inputNum = Console.ReadLine();
//вар. 1
if (inputNum != null)
{
    string[] dayNames = new string[7];
    dayNames[0] = "понедельник";
    dayNames[1] = "вторник";
    dayNames[2] = "среда";
    dayNames[3] = "четверг";
    dayNames[4] = "пятница";
    dayNames[5] = "суббта";
    dayNames[6] = "воскресенье";
    int day = (int.Parse(inputNum)-1) % 7;
    Console.WriteLine(dayNames[day]);
}

        // Console.Write("input yor day num: ");
        // if (inputNum!=null){
        // int day = Math.Abs(int.Parse(Console.ReadLine())%7)-1;
        // Console.WriteLine(day);
