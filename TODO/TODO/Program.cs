using System;
using System.Collections.Generic;

Console.WriteLine("Hello!");

List<string> todos = new List<string>();
while(true)
{
    Main(todos);
}


void Main(List<string> todoList)
{

    Console.WriteLine("What do you want to do?");
    string userChoice;
    do
    {
        Console.WriteLine("[S]ee all TODOs");
        Console.WriteLine("[A]dd a TODO");
        Console.WriteLine("[R]emove");
        Console.WriteLine("[E]xit");

        userChoice = Console.ReadLine();
        userChoice = userChoice.ToUpper();

        if (!ValidUserChoice(userChoice))
        {
            Console.WriteLine("Incorrect input");
        }

    } while (!ValidUserChoice(userChoice));

    switch (userChoice)
    {
        case "S":
            if (todoList.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet");
            }
            else
            {
                int i = 1;
                foreach (var todo in todoList)
                {
                    Console.WriteLine($"{i}. {todo}");
                    i++;
                }
            }
            break;

        case "A":

            string todoDescription;
            do
            {
                Console.WriteLine("Enter the TODO description");
                todoDescription = Console.ReadLine();

                EmptyTodoDescription(todoDescription);
                NotUniqueDescription(todoDescription, todoList);

            } while (!ValidTodoDescription(todoDescription, todoList));

            todoList.Add(todoDescription);
            Console.WriteLine($"TODO sucessfully added: {todoDescription}");
            break;

        case "R":
            Console.WriteLine("Select the index of the TODO you want to remove: ");

            if (todoList.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet");
                break;
            }

            int j = 1;
            foreach (var todo in todoList)
            {
                Console.WriteLine($"{j}. {todo}");
                j++;
            }

            string userSelection;
            do
            {
                userSelection = Console.ReadLine();

                if (userSelection.Length==0)
                {
                    Console.WriteLine("Selected index cannot be empty");
                    Console.WriteLine("Select the index of the TODO you want to remove: ");
                }
                else
                {
                    InvalidIndex(userSelection, todoList);
                }

            } while (!IsValidIndex(userSelection, todoList));


            int parsedSelection = int.Parse(userSelection);
            string removedTodoDescription = todoList[(parsedSelection-1)];

            todoList.RemoveAt((parsedSelection-1));

            Console.WriteLine($"TODO removed: {removedTodoDescription}");
            break;

        case "E":
            Environment.Exit(1);
            break;
    }

}


bool IsValidIndex(string userSelection, List<string> todoList)
{
    int number;
    bool parseable = int.TryParse(userSelection, out number);
    if (userSelection.Length>0 && number!=0 && parseable && number<=todoList.Count)
    {
        return true;
    }

    return false;
}

void InvalidIndex(string userSelection, List<string> todoList)
{
    int number;
    var parsedSelection = int.TryParse(userSelection, out number);
    if(!parsedSelection || number>todoList.Count || number==0)
    {
        Console.WriteLine("The given index is not valid");
        Console.WriteLine("Select the index of the TODO you want to remove: ");
    }
}


void EmptyTodoDescription(string todoDescription)
{
    if (todoDescription.Length == 0)
    {
        Console.WriteLine("The description cannot be empty");
    }
}

void NotUniqueDescription(string todoDescription, List<string> todoList)
{
    if (todoList.Contains(todoDescription))
    {
        Console.WriteLine("The description must be unique");
    }
}

bool ValidTodoDescription(string todoDescription, List<string> todoList)
{
    if(todoDescription.Length>0 && !todoList.Contains(todoDescription))
    {
        return true;
    }
    return false;
}


bool ValidUserChoice(string choice)
{
    switch (choice)
    {
        case "S":
        case "A":
        case "R":
        case "E":
            return true;
        default: return false;
    }
}
