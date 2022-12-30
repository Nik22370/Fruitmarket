namespace Fruitmarket;

public class Owner : Person
{
    
    public string Companyname { get; set; }
    public Owner(Person person, string companyname) : base(person.Firstname, person.Lastname, person.Address)
    {
        Companyname = companyname;
    }

    public void changeCompanyname(string companyname)
    {
        Companyname = companyname;
    }
}