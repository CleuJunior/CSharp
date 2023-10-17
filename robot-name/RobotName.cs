using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly HashSet<string> UsedNames = new();
    private string _name;

    public Robot() => Reset();

    public string Name => _name;

    public void Reset()
    {
        string newName;
        do
        {
            newName = GenerateRandomName();
        } while (UsedNames.Contains(newName));

        if (!string.IsNullOrEmpty(_name))
        {
            UsedNames.Remove(_name);
        }

        UsedNames.Add(newName);
        _name = newName;
    }

    private string GenerateRandomName()
    {
        Random random = new Random();
        string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string name = "";
        name += letters[random.Next(26)];
        name += letters[random.Next(26)];
        name += random.Next(10);
        name += random.Next(10);
        name += random.Next(10);
        return name;
    }
}