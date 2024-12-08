List<int> list1 = new();
List<int> list2 = new();
int distance = 0;
string inputFilePath = "R:\\MichielVanHerreweghe\\Advent of Code\\advent-of-code-2024\\src\\day-01\\input.txt";

IEnumerable<string>? lines = File.ReadLines(inputFilePath);

foreach (string line in lines)
{
    list1.Add(
        int.Parse(
            line.Split("   ")[0]
        )
    );

    list2.Add(
        int.Parse(
            line.Split("   ")[1]
        )
    );
}

list1.Sort();
list2.Sort();

for (int i = 0; i < list1.Count; i++)
{
    distance += Math.Abs(list1[i] - list2[i]);
}

Console.WriteLine(
    $"The distance between the two lists is {distance}"
);