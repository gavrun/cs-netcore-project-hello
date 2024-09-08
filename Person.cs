namespace cs_netcore_project_hello;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Method to return the full name of the person
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}
