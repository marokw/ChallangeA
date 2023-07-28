
/// Wyniki dla liczby: 12353236
/// 0 -> 0
/// 1 -> 1
/// 2 -> 2
/// 3 -> 3
/// 4 -> 0
/// 5 -> 1
/// 6 -> 1
/// 7 -> 0
/// 8 -> 0
/// 9 -> 0


long number = new Random().NextInt64(1000000000000,10000000000000);
string numbersInString = number.ToString();
char[] letters = numbersInString.ToArray();
int[] count = new int[10];

for (int i = 0; i < 10; i++)
    count[i] = 0;

Console.WriteLine("Wyniki dla liczby:" + numbersInString);

foreach(char letter in letters)
    count[letter - '0']++;

for (int i=0; i < 10; i++)
    Console.WriteLine(i + " -> " + count[i]);
