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

// -=-=-=-=- PROFESSOR VERSION -=-=-=-=-=--=
// whenever creating switches, prefer to use methods for each condition instead of writing it in the switch brackets instead
// remember that the following code is refactored. It was not first wrote like that. https://www.udemy.com/course/ultimate-csharp-masterclass/learn/lecture/33511688#overview
Console.WriteLine("What do you want to do? ");

bool shallExit = false;
while (!shallExit)
{


    Console.WriteLine("[S]ee all todos ");
    Console.WriteLine("[A]dd a todo ");
    Console.WriteLine("[R]emove a todo ");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "E":
        case "e":
            shallExit = true;
            break;
        case "S":
        case "s":
            SeeAllTodos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}

void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter the TODO description");
        description = Console.ReadLine();

    } while (!IsDescriptionValid(description));

    todos.Add(description);
}

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        NoTODOsAdded();
        return;
    }
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i+1}. {todos[i]}");
    }
}

void RemoveTodo()
{
    if (todos.Count == 0)
    {
        NoTODOsAdded();
        return;
    }

    int index;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove");
        SeeAllTodos();
    } while (!TryReadIndex(out index));

    RemoveTodoAtIndex(index);
}

bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();
    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty");
        return false;
    }

    if (int.TryParse(userInput, out index) &&
        index >= 1 &&
        index <= todos.Count)
    {
        return true;
    }
    Console.WriteLine("The given index is not valid.");
    return false;
}


void NoTODOsAdded()
{
    Console.WriteLine("Not TODOs have been added");
}

void RemoveTodoAtIndex(int index)
{
    var todoToBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("TODO removed: " + todoToBeRemoved);
}

bool IsDescriptionValid(string description)
{
    if (description == "")
    {
        Console.WriteLine("The description cannot be empty");
        return false;
    }

    if (todos.Contains(description))
    {
        Console.WriteLine("The description must be unique");
        return false;
    }

    return true;
}
