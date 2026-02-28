Console.WriteLine("What is your name?");
string userName = Console.ReadLine(); 
Console.WriteLine("Hello " + userName); 
int firstNum = Convert.ToInt32(Console.ReadLine()); 
int secondNum = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(firstNum + secondNum);
Console.Write("Input 1: ");
string input1 = Console.ReadLine();
Console.Write("Input 2: ");
string input2 = Console.ReadLine();
Console.Write("Input 3: ");
string operation = Console.ReadLine();

double firstNum, secondNum;
bool isFirstCorrect = double.TryParse(input1, out firstNum);
bool isSecondCorrect = double.TryParse(input2, out secondNum);

if (!isFirstCorrect) Console.WriteLine("Input 1 is wrong type.");
if (!isSecondCorrect) Console.WriteLine("Input 2 is wrong type.");

if (isFirstCorrect && isSecondCorrect) {
    if (operation == "add") {
        Console.WriteLine($"Answer is {firstNum + secondNum} ({firstNum}+{secondNum}={firstNum + secondNum})");
    } else if (operation == "subtract") {
        Console.WriteLine($"Answer is {firstNum - secondNum} ({firstNum}-{secondNum}={firstNum - secondNum})");
    } else if (operation == "multiply") {
        Console.WriteLine($"Answer is {firstNum * secondNum} ({firstNum}*{secondNum}={firstNum * secondNum})");
    } else if (operation == "divide") {
        Console.WriteLine($"Answer is {firstNum / secondNum} ({firstNum}/{secondNum}={firstNum / secondNum})");
    } else {
        Console.WriteLine("Input 3 is wrong type.");
    }
}
 
// I used artificial intelligence.
