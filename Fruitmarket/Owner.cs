namespace Fruitmarket;

public class Owner : Person
{
    
    public string Companyname { get; set; }
    public Owner(Person person, string companyname) : base(person.Firstname, person.Lastname, person.Address)
    {
        Companyname = companyname;
    }
#pragma warning disable CS8618
    protected Owner() { }
#pragma warning restore CS8618

    public void changeCompanyname(string companyname)
    {
        Companyname = companyname;
    }
}