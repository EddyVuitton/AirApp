namespace AirApp.Data.Entities;

public class Passenger
{
    private readonly int _id;
    private readonly string _name;
    private PassengerAge _age;

    public Passenger(string name, PassengerAge age, ref List<Passenger> passengers)
    {
        _id = passengers is null ? 1 : passengers.Count == 0 ? 1 : passengers.Max(x => x._id) + 1;
        _name = name;
        _age = age;
    }

    public int GetId() => _id;
    public string GetName() => _name;
    public PassengerAge GetPassengerAge() => _age;

    public void ChangeAge(PassengerAge age) { _age = age; }
}