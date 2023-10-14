namespace BankLibrary
{
    public class PersonInfo
    {
        public static string GetPersonInfo(Person person)
        {
            return $"Имя: {person.FirstName}, Фамилия: {person.LastName}, Возраст: {person.Age}, Адрес: {person.Address}";
        }
    }
}
