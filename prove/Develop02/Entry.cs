using System;

public class Entry 
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display() 
    {
        Console.WriteLine($"\n{_date}\n{_promptText}\n{_entryText}");
    }
}
