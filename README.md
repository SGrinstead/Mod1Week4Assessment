# Mod1 Week4 Assessment
This assessment has two parts - some questions about this week's lessons, and an exercise focused on our Testing lesson. Work on the Questions first, then move on to the Exercise!

## Setup

Fork this repository!

## Questions (12 Points Possible)
Edit this `README.md` file - answer the BLANK questions before moving on to the exercise.  Make sure to SAVE your changes to the README before moving on!

1. Review the class definition below:
    ```c#
    public class Chair
    {
        public int Height { get; }
        public bool HasBack { get; }

        public Chair(int height, bool hasBack)
        {
            Height = height;
            HasBack = hasBack;
        }
    }
    ```
    Which of the following is NOT a valid way to create an instance of Chair? And why does this option not work?  
    A. `var bench = new Chair(24, true);`  
    B. `Chair bench = new Chair(24, true);`  
    C. `var bench = new(24, true);`  
    D. `Chair bench = new(24, true);`  
    
    C is not valid. You have to state the type of object you are trying to create at some point.
    
2. Imagine you are interviewing for your first job.  The interviewer asks "What can you tell me about OOP?".  Write your response below:

Object oriented programming is the practice of defining the things you are working with as objects that can model state and behavior. This makes interaction between parts of your code much simpler and keeps it more organized as an added benefiet.


3. What is Automated Testing?

Automated testing is the process of making a test project alongside the project you are working on to see if parts of your project function as expected.


4. What are some benefits of creating tests for our projects?

Creating tests this way is faster and keeps your code more organized. You also don't have to keep adding and deleting lines in your main project to test if it is working.


5. When you create a test project, you do not immediately have access to the class(es) in the project that you are testing.  What do you need to do in order to have access to those classes?

You must add a project reference to the test project so it can access the classes in the original.

6. Take a look at the class below.  Write out the **names** of each test you would write to verify that this class is working.
```c#
    public class Vehicle
    {
        public int NumberOfWheels { get; }
        public string Color { get; private set;  }
        public int MilesDriven { get; private set; }

        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
            MilesDriven = 0;
        }

        public string Sumary()
        {
            string summary = $"This {Color} vehicle has {NumberOfWheels} wheels, and has driven {MilesDriven} miles.";
            return summary;
        }

        public void Drive()
        {
            MilesDriven += 5;
        }

        public void Paint(string newColor)
        {
            Color = newColor;
        }
    }
```

VehicleIsConstructed_With_Wheels_Color_MilesDriven

SummaryMethod_Returns_String_With_Properties

DriveMethod_Adds5To_MilesDriven

PaintMethod_Changes_Color



## Exercise (8 Points Possible)
In Visual Studio, clone your forked repository.  
In this solution, there is a `Vehicle` project and a `Vehicle.UnitTests` project.  The class in `Vehicle.cs` is complete, but the tests for that class are not yet finished.  Add tests to the `VehicleTests.cs` file so that all the methods and properties for the `Vehicle` class have tests.  When finished, there should be a minimum of 4 tests (one is already completed for you!).

### Submission

When completed, commit the progress you have made, and push your project to GitHub.  Instructors will be following up with some video feedback!

### Rubric

This assessment has a total of **20 Points**.  Earning **10 or more** points is a **pass** and will indicate that you are progressing well with the material.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
