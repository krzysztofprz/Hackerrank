// Task: Find the Longest Sequence of Repeated Characters
// Implement a method that analyzes a given string and returns the length of the longest sequence of consecutive identical characters.

// Console.WriteLine(CountOccurrences("aabbcaaa")); // Output: 3 'a' occurres 3 times in a row
// Console.WriteLine(CountOccurrences("aabbcccaa")); // Output: 3 'c' occurres 3 times in a row
// Console.WriteLine(CountOccurrences("aabbcccaaeeeeaooooooooo")); // Output: 9 'o' occurres 9 times in a row
// Console.WriteLine(CountOccurrences("abcde")); // Output: 1 any char occurres 1 times in a row
// Console.WriteLine(CountOccurrences("")); // Output: 0

static int CountOccurrences(string input)
{
    if (string.IsNullOrEmpty(input))
    {
        return 0;
    }

    var max = 1;
    var current = 1;

    char last = input[0];

    for (var i = 1; i < input.Length; i++)
    {
        if (input[i] != last)
        {
            last = input[i];
            current = 1;
            continue;
        }

        current++;

        if (current > max)
        {
            max = current;
        }
    }

    return max;
}