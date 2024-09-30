## Assignment: Running Tracker Application

### Objective
Design and implement a Running Tracker Application using Object-Oriented Programming principles in C# and .NET. This project will help you demonstrate your understanding of OOP concepts such as abstraction, encapsulation, inheritance, and polymorphism, as well as your ability to design and develop a functional application.

### Requirements

1. **Classes and Objects:**
   - Create a base class `Run` with the following properties:
     - `RunID` (string)
     - `UserID` (string)
     - `Distance` (double, in kilometers)
     - `Duration` (TimeSpan)
     - `Date` (DateTime)
   - Implement methods for:
     - `StartRun()`
     - `EndRun()`
     - `GetRunDetails()`

1. **Inheritance:**
   - Develop derived classes for different types of runs:
     - `OutdoorRun` (inherits `Run`)
     - `TreadmillRun` (inherits `Run`)
   - Each derived class should have additional properties and methods specific to the run type. For example, `OutdoorRun` might have a `Route` property and a method to get the route details.

1. **Polymorphism:**
   - Implement polymorphic behavior by overriding methods in the derived classes. For example, override the `GetRunDetails` method to include specific details for each run type.

1. **Abstraction:**
   - Use interfaces to define common behaviors. For example, create an `IRun` interface.

1. **Coordinates and Mapping:**
   -  Implement representation for GPS coordinates
   -  Add properties to the `OutdoorRun` class to handle GPS coordinates:
     - `StartCoordinates`
     - `EndCoordinates`
     - `RouteCoordinates` 
   - Implement methods to:
     - `AddCoordinate(double latitude, double longitude)` to track the route during the run.
     - `CalculateDistance()` to compute the total distance based on the coordinates.
        - use Haversine formula for calculation

1. **User Interface:**
   - Create a simple console-based user interface that will showcase implemented features.
   - You can mock user inputs direcly in main function of a program

### Deliverables

1. **Source Code:**
   - Present source code to the lecture tutor

### Evaluation Criteria
- Correctness and completeness of the implementation
- Adherence to OOP principles and design patterns
- Code quality and readability
- Effective use of C# and .NET features
