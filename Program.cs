int[] array1 = {0,1,2,3,4,5,6,7,8,9};
string[] array2 = {"Tim", "Martin", "Nikki", "Sara"};
bool[] array3 = new bool[10];

for (int i = 0; i < array3.Length; i++)
{
    if (i % 2 == 0)
    {
        array3[i] = true;
    }
    else
    {
        array3[i] = false;
    }
}

List<string> flavors = new List<string>();
flavors.Add("Chocolate");
flavors.Add("Vanilla");
flavors.Add("Strawberry");
flavors.Add("Rocky Road");
flavors.Add("Moose Tracks");

System.Console.WriteLine(flavors.Count);
System.Console.WriteLine(flavors[2]);
flavors.RemoveAt(2);
System.Console.WriteLine(flavors.Count);

Dictionary<string,string> dict = new Dictionary<string, string>();
Random rand = new Random();
foreach (string name in array2)
{
    dict.Add(name, flavors[rand.Next(0,flavors.Count)]);
}

foreach (KeyValuePair<string,string> entry in dict)
{
    System.Console.WriteLine($"{entry.Key} - {entry.Value}");
}