namespace Fruitmarket;

public class Person
{
    public int Id { get; private set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public Address Address { get; set; }

    public Person(string firstname, string lastname, Address address)
    {
        Firstname = firstname;
        Lastname = lastname;
        Address = address;
    }

    public void changeFirstname(string firstname)
    {
        Firstname = firstname;
    }

    public void changeLastname(string lastname)
    {
        Lastname = lastname;
    }

    public void changeAddress(Address address)
    {
        Address = address;
    }
}