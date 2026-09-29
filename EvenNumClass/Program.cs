using EvenNumClass;

string[] tokens = Console.ReadLine().Split(' ');

List<int> allNumbers = new List<int>();
foreach (var token in tokens)
{
    allNumbers.Add(int.Parse(token));
}

List<EvenNumber> evenNumbersList = new List<EvenNumber>();
foreach (int item in allNumbers)
{
    if (item % 2 == 0)
    {
        evenNumbersList.Add(new EvenNumber(item));
    }
}

List<string> printedResult = new List<string>();
foreach (EvenNumber evenObj in evenNumbersList)
{
    printedResult.Add(evenObj.Num.ToString());
}

Console.WriteLine(string.Join(", ", printedResult));
