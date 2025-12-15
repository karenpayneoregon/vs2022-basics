using TeachingLibrary.Models;

namespace TeachingLibrary.Classes;
public class MockedData
{
    public static ISet<Person> PeopleData()
    {
        ISet<Person> peopleSet = new HashSet<Person>(PeopleListData());

        return peopleSet;
    }

    public static List<Person> PeopleListData()
    {
        List<Person> peopleList = new List<Person>([
            new() { Id = 1, FirstName = "Karen", LastName = "Payne",
                BirthDate = new DateOnly(1956,9,24)},
            new() { Id = 2, FirstName = "Sam", LastName = "Smith",
                BirthDate = new DateOnly(1976,3,4) },
            new() { Id = 1, FirstName = "Karen", LastName = "Payne",
                BirthDate = new DateOnly(1956,9,24) }
        ]);
        return peopleList;
    }
}
