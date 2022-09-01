/* Write a program and ask the user to continuously enter a number or type "Quit" to exit.
 * The list of numbers may include duplicates.  Display the unique numbers that the use entered.*/

string userInput = "";
List<int> numbers = new List<int>();

while (!userInput.ToLower().Equals("quit"))
{
    Console.WriteLine("Please enter a number.");
    userInput = Console.ReadLine();
    bool validNumber = int.TryParse(userInput, out int result);
    if (!validNumber)
        continue;
    numbers.Add(result);
}
PrintUniqueNumbers(numbers);

static void PrintUniqueNumbers(List<int> numbers)
{
    List<int> uniqueNumbers = numbers.Distinct().ToList();

    Console.WriteLine(String.Join(", ", uniqueNumbers));
}