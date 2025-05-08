using System;

class MyInfo
{
    private string _name;
    public event Action<string> NameChanged; 
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            NameChanged?.Invoke(_name); 
        }
    }
}