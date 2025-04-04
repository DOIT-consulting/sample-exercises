/*
    ------------------------------------------------------------------
    MINI-PROGRAM
    ------------------------------------------------------------------

    Below, you will find instructions for each exercise level (Easy, Medium, Difficult),
    as well as a suggested final step regarding Dependency Injection (DI) and Interfaces.

    You are asked to:
        1) Fix an existing bug in the current code.
        2) Implement or extend functionalities at three different difficulty levels.
        3) (Optionally) introduce an interface-based architecture and DI as a final step.

    ------------------------------------------------------------------
    OVERVIEW
    ------------------------------------------------------------------
    - Finally, we discuss how to refactor the code using interfaces and a DI container.

    ------------------------------------------------------------------
    EXERCISE INSTRUCTIONS
    ------------------------------------------------------------------

    1) EASY (Bug Fix & Basic LINQ)
    ----------------------------------------------------------
    - Find and solve the bug
    - OPTIONAL: Print out the entire list of loaded people or filter them using a
      LINQ query (e.g., print only those with Age >= 18).

    2) MEDIUM (Extended Functionality)
    ----------------------------------------------------------
    - After fixing the bug, implement one or more new features:
      a) Filtering people by name (prompt the user and search).
      b) Calculating statistics (e.g., average age).
      c) Adding a method that allows insertion of a new Person into the repository.
    - Use appropriate LINQ methods (Where, Average, etc.) and handle edge cases
      (empty list, invalid inputs, etc.).

    3) DIFFICULT (Interfaces & Dependency Injection)
    ----------------------------------------------------------
    - Introduce an interface 'IPersonRepository' and a concrete 'FakePersonRepository' class.
    - In a real-world scenario, we would inject 'IPersonRepository' via a DI container
    - Consider adding another repository implementation (e.g., 'DbPersonRepository')
      to highlight how DI allows us to swap the data source without changing code logic.

    4) OPTIONAL (Concurrency / Parallel Processing)
    ----------------------------------------------------------
    - Create a new method, for example 'ProcessPersonsInParallel(List<Person> persons)', 
      which might:
        * Split the list into multiple segments.
        * Run tasks in parallel to simulate heavy computations or network calls.
        * Print the result as each task completes.
    - If you need to store processed results in a shared collection, consider using a
      thread-safe structure or locks/Semaphores.
    - Demonstrate safe exception handling and consider a possible cancellation mechanism

    ------------------------------------------------------------------
    GOOD LUCK!
    ------------------------------------------------------------------
*/


Console.WriteLine("Start process...");

var personRepository = new FakePersonRepository();

var persons = personRepository.LoadPersons();

Console.WriteLine($"First result is: {persons[0].Name}");

Console.WriteLine("End process");
Console.ReadLine();