using fbn.Data;
// Metodo para calcular a idade a partir da data de nascimento

public class Calc
{
    private readonly Person _person;

    public Calc(Person person)
    {
        _person = person;
    }

    public int ConvertDate()
    {
        // Convertendo o DateBirth (long) para DateTime
        DateTime dateOfBirth = new DateTime(_person.DateBirth);
        return CalcAge(dateOfBirth);
    }

    public int CalcAge(DateTime dateOfBirth)
    {
        var today = DateTime.Today;
        int age = today.Year - dateOfBirth.Year;

        if(dateOfBirth.Date > today.AddYears(-age)) age--;

        return age;
    }
}