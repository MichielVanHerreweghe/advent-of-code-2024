string inputFilePath = "R:\\MichielVanHerreweghe\\Advent of Code\\advent-of-code-2024\\src\\day-02\\input.txt";
int amountOfSafeReports = 0;

IEnumerable<string>? reports = File
    .ReadLines(
        inputFilePath
    );

foreach (string report in reports)
{
    IEnumerable<int> levels = report
        .Split(
            ' '
        )
        .Select(
            level => int
                .Parse(
                    level
                )
        );

    bool isSafe = CheckIfReportIsSafe(
        levels
    );

    if (isSafe)
    {
        amountOfSafeReports++;
    }
}

Console.WriteLine(
    $"Amount of safe reports: {amountOfSafeReports}"
);

bool CheckIfReportIsSafe(
    IEnumerable<int> levels
)
{
    int previousValue = 0;
    bool shouldBeIncrease = false;

    for (int i = 0; i < levels.Count(); i++)
    {
        int level = levels.ElementAt(i);

        if (i == 0)
        {
            previousValue = level;
            continue;
        }

        if (i == 1)
        {
            shouldBeIncrease = level > previousValue;
        }

        if (shouldBeIncrease != level > previousValue)
        {
            return false;
        }

        int absoluteValue = Math.Abs(level - previousValue);
        bool isWithinAcceptableTreshold = 1 <= absoluteValue && absoluteValue <= 3;

        if (!isWithinAcceptableTreshold)
        {
            return false;
        }

        previousValue = level;
    }

    return true;
}