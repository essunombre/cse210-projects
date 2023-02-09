public class Customer
{
    private string _name = "";
    private Address address;
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

}