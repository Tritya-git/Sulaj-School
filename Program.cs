List<int> child_avrage = new List<int>();

List<bool> family_succes_rate = new List<bool>();

Random R = new Random();
Console.WriteLine("Pár?");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Gyerek?");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("----------------");

for (int i = 0; i < N; i++)
{
    int male = 0;
    int female = 0;
    int counter = M;
    do
    {
        int num = R.Next(0, 101);
        if (num > 50)
        {
            male++;
        }
        else
        {
            female++;
        }
        counter--;
    } while (male != female && counter > 0);
    family_succes_rate.Add(male == female ? true : false);
    child_avrage.Add(male + female);
}

// average
int átlag = 0;
for (int i = 0; i < child_avrage.Count(); i++)
{
    Console.WriteLine(child_avrage[i]);
    átlag += child_avrage[i];
}
Console.WriteLine($"Átlag gyermek szám: {átlag / child_avrage.Count()}");
Console.WriteLine("----------------");
// percent
int percent = 0;
for (int i = 0; i < family_succes_rate.Count(); i++)
{
    Console.WriteLine(family_succes_rate[i]);
    if (family_succes_rate[i] == true)
    {
        percent++;
    }
}
Console.WriteLine($"Siker százalékosan: {(percent * 100) / family_succes_rate.Count()}%");