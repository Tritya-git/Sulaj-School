List<bool> börtön = new List<bool>();

for (int i = 0; i < 100; i++)
{
    börtön.Add(true);
}

int num = 1;

while (num < börtön.Count)
{
    for (int j = 0; j < börtön.Count; j++)
    {
        if (j % num == 0)
        {
            if (börtön[j] == true)
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

for (int i = 0; i < börtön.Count; i++)
{
    if (börtön[i] == false)
    {
        Console.WriteLine(i);
    }
}