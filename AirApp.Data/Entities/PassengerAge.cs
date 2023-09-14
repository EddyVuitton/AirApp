namespace AirApp.Data.Entities;

public class PassengerAge
{
    private readonly int _id;
    private readonly string _name;

    public PassengerAge(int id, string name)
    {
        _id = id;
        _name = name;
    }

    public int GetId() => _id;
    public string GetName() => _name;
}