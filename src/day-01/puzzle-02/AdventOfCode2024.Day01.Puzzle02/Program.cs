List<int> list1 = new();
List<int> list2 = new();
string inputFilePath = "R:\\MichielVanHerreweghe\\Advent of Code\\advent-of-code-2024\\src\\day-01\\input.txt";
int similarityScore = 0;

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

for (int i = 0; i < list1.Count; i++)
{
    int number = list1[i];

    int amountOfOccurences = list2.Count(
        x => x == number
    );

    similarityScore += amountOfOccurences * number;
}

Console.WriteLine(
    $"The similarity score is {similarityScore}"
);