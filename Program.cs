using System;

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// Let the moose speak!
MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic.");

// Ask a question
bool isTrue = MooseAsks("Is Canada real?");
if (isTrue)
{
    MooseSays("Really? It seems very unlikely.");
}
else
{
    MooseSays("I  K N E W  I T !!!");
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |     {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}
bool MooseAsks(string question)
{ //^ bool is going to need True or False returned at the end. 
    Console.Write($"{question} (Y/N): ");
    //^ Console Log the question fed to this bool function, as a string, above. 
    string answer = Console.ReadLine().ToLower();
    // ^ declare a string variable, answer, and read the next line of characters, converting them to lower case
    while (answer != "y" && answer != "n")
    { //^ If the user answer isn't Y, y, N, or n: try again. 
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
        //^ write the question, and read the user's input, converted to lower case. 
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}