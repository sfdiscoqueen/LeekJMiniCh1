// Jasmine Leek
// 18 Oct 2022
// Mini-Challenge #1 "What is your name?"
// This is a simple application that will ask the user for their name, then say hello to them.

Console.Clear();
bool playAgain = true;

while (playAgain)
{
    Console.Write("Hello! Please enter your name: ");

    string myName = Console.ReadLine();
    // Console.WriteLine("");
    Console.WriteLine($"\nHi *.*.* {myName} *.*.*! It's nice to meet you. \n");
    // Console.WriteLine("");
    Console.Write("Want to play again? \n \nEnter any key to restart or type 'end' to quit: ");

    string ready = Console.ReadLine();
    if (ready == "end")
    {
        playAgain = false;
    }
}