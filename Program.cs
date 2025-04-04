Console.WriteLine("Start process...");

var personRepository = new FakePersonRepository();

var persons = personRepository.LoadPersons();

Console.WriteLine($"First result is: {persons[0].Name}");

Console.WriteLine("End process");
Console.ReadLine();