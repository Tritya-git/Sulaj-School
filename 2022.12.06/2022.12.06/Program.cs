/*
List<string> list = new List<string>();
Random random = new Random();

for (int i = 0; i < 13; i++)
{
    int r = random.Next(0, 101);
    if(r <= 50)
    {
        list.Add("1");
    }
    else if(r>50 && r <= 70)
    {
        list.Add("2");
    }
    else
    {
        list.Add("x");
    }
}

foreach(string i in list)
{
    Console.WriteLine(i);
}


Random random = new Random();
List<int> list1 = new List<int>();
List<int> list2 = new List<int>();
List<int> nice = new List<int>();
for (int i = 0; i < 50; i++)
{
   int r =  random.Next(1,501);
    
    int num = r / 100 + (r % 100) / 10 + ((r%100) % 10 )/ 1;

    if (r > 100 && r % 2 == 0)
    {
        list1.Add(r);
    }
     else if(r < 200 && num % 5 == 0 || r > 300 && num % 5 == 0)
    {
        list2.Add(r);
    }

}

while (true)
{
    foreach (int i in list1)
    {
        if (i % 3 == 0 && i % 7 != 0)
        {
            nice.Add(i);
        }

    }
    foreach (int i in list2)
    {
        if (i % 3 == 0 && i % 7 != 0)
        {
            nice.Add(i);
        }

    }
   Console.WriteLine(nice.Max());
    break;
}
*/

List<bool> börtön = new List<bool>();

for(int i = 0; i < 100; i++)
{
    börtön.Add(true);
}

int num = 1;

while(num < börtön.Count)
{
    for (int j = 0; j < börtön.Count; j++)
    {
        if (j % num == 0)
        {
            if(börtön[j] == true)
            {
                börtön[j] = false;
            }
            else
            {
                börtön[j] = true;
            }
        }
    }
    num++;
}

for(int i = 0; i < börtön.Count;i++)
{
    if (börtön[i] == false)
    {
        Console.WriteLine(i);
    }
}