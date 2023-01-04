var myPerson = new Person
{
    FirstName = "FirstName",
    LastName = "LastName"
};

Console.WriteLine(myPerson.ToString("FL"));
Console.WriteLine(myPerson.ToString("LF"));
Console.WriteLine(myPerson.ToString("F"));
Console.WriteLine(myPerson.ToString("L"));
Console.WriteLine(myPerson.ToString("NONE"));

class Person : IFormattable
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public string ToString(string? format, IFormatProvider? formatProvider = null) => format switch
    {
        "FL" => FirstName + " " + LastName,
        "LF" => LastName + " " + FirstName,
        "F" => FirstName,
        "L" => LastName,
        _ => "Not Implemented"
    };
}