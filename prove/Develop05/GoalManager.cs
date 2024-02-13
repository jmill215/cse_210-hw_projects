using System;


public class GoalManager
{

    protected List<Goal> _goals = new List<Goal>();

    private string _score;

    //call class to initialize the score
    public GoalManager()
    {
        _score = 0;
    }
    public void start()
    {
        //initializing variable
        int userInput = 0;
        //entire menu will be placed within this function
        while(userInput != 6) {

            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());
            
            if (userInput == 1)
            {
                CreateGoal();

            } else if (userInput == 1)
            {
                ListGoalNames();
            } else if (userInput == 1)
            {
                SaveGoals();
            } else if (userInput == 1)
            {
                LoadGoals();
            } else if (userInput == 1)
            {
                RecordEvent();
            } else if (userInput == 6)
            {
                Console.WriteLine("Thank you for using this program!");
            } else {
                Console.WriteLine("Invalid input, please try again!");
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You currently have {_score} points.\n");
    }

    public void ListGoalNames()
    {
       //slight copy of ListGoalDetails, but to list current goals
       int listNum = 1;
       foreach(Goal g in _goals)
       {
        Console.WriteLine($"{listNum}. {g.getGoalName()}");
        listNum++;
       }
       

    }

    public void ListGoalDetails()
    {
         //test for goal count
        if(_goals.Count == 0){
            Console.WriteLine("There are no goals currently, add one through the menu, and they will display here upon the next selection.");
        } else {
            //call ListGoalDetails, and iterate through them, using an additional i or other number to make sure the list remains cohesive
            int listNum = 1;
            foreach(Goal g in _goals)
            {
                Console.WriteLine($"{listNum}. {g.GetDetailsString()}");
                listNum++;
            }

        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe Types of Goals are: ");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userI = Console.ReadLine();
        int userInp = int.Parse(userI);

        Console.Write("/nWhat is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("/nWhat is a short description of it? ");
        string goalDesc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?");
        string goalPoints = Console.ReadLine();

        Goal newGoal;
        if (userInp == 3)
        {
            Console.Write("\nHow many times does this goal need to be accomplished to obtain bonus points? ");
            int goalTargetAttempts = int.Parse(Console.ReadLine());

            Console.Write($"What is the bonus for accomplishing it {goalTargetAttempts} times? ");
            int goalBonus = int.Parse(Console.ReadLine());
            newGoal = new CheckListGoal(goalName, goalDesc, goalPoints, goalTargetAttempts, goalBonus);
            _goals.Add(newGoal);
        } else if(userInp == 2)
        {
            newGoal = new EternalGoal(goalName, goalDesc, goalPoints);
            _goals.Add(newGoal);
        } else if(userInp == 1)
        {
            newGoal = new SimpleGoal(goalName, goalDesc, goalPoints);
            _goals.Add(newGoal);
        }
        
    }

    public void RecordEvent()
    {   
        Console.Clear();
        //check for any goals prior to changing score, return if no goals exist
        if(_goals.Count == 0)
        {
            Console.WriteLine("There are no goals in the list. Please create a goal first before recording an event");
            return;
        }
        ListGoalNames();
        Console.Write("\nWhich goal did you accomplish? ");
        string x = Console.ReadLine();
        int i = int.Parse(x) - 1; //matching indexes, hence -1

        _score += _goals[i].RecordEvent();
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat filename should this be saved under?");
        string fileN = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileN)){
            outputFile.WriteLine($"Score~{_score}");

            //for each to write to file
            foreach(Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }   
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the filename of the file you would like to load? ");
        string fileN = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileN);

        foreach(string line in lines)
        {
            string[] parts = line.Split("~");

            //attempting to use switch cases
            Goal newGoal;

            switch (parts[0])
            {
                case "Score":
                    _score = (parts[1]);
                    break;
                case "SimpleGoal":
                    newGoal = new SimpleGoal(parts[1], parts[2], parts[3]);
                    break;
                case "EternalGoal":
                    
                    break;
                case "ChecklistGoal":
                   
                    break;
                default:
                    Console.WriteLine("Unable to read part of file.");
                    break;
            }
        }
    }
}