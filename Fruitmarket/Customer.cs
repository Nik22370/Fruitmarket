namespace Fruitmarket;

public class Customer : Person
{
    
    public string Creditcard { get; set; }
    public Customer(Person person, string creditcard) : base(person.Firstname, person.Lastname, person.Address)
    {
        Creditcard = creditcard;
    }

    public void changeCreditcard(string creditcard)
    {
        Creditcard = creditcard;
    }
}