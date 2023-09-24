namespace Library;

public class Person
{
    public string Name { get; set; }
    public string Id { get; set; }

    public Person(string name, string id)
    {
        this.Name = name;
        this.Id = id;

        ValidateName();
        ValidateId();
    }

    public void IntroduceYourself()
    {
        Console.WriteLine($"Soy {this.Name} y mi cédula es {this.Id}");
    }

    public bool NameIsValid()
    {
        // si name es distinto de "" se retorna true, sino false
        return Name.Trim() != "";
    }

    public void ValidateName()
    {
        if (!NameIsValid())
            throw new Exception($"El nombre {Name} es incorrecto!");
    }

    public void ValidateId()
    {
        if (!IdUtils.IdIsValid(Id))
            throw new Exception($"La cedula {Id} no es valida!");
    }
}