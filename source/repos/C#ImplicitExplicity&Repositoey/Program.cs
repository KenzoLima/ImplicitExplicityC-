double x = 100;
int y = (int)x; // Explicit cast from double to int

Console.WriteLine(y);


//impicit operator
var telefone = "55 43 996789465";
Phone phone = telefone; // Conversão implicita do phone para string
Console.WriteLine(phone);
public class Phone
{
    public string CountryCode { get; set; }
    public string Area { get; set; }
    public string Number { get; set; }

    public override string ToString() => $"+{CountryCode} ({Area}) {Number}";

    public static implicit operator string(Phone phone)
    {
        return phone?.ToString();
    }
    

    public static implicit operator Phone(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto)) return null;

        var parts = texto.Split(' ');

        return new Phone
        {
            CountryCode = parts[0],
            Area = parts[1],
            Number = parts[2]
        };
    }
}