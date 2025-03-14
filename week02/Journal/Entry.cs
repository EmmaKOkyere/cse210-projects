using System;

public class NewBaseType
{
    public static Entry FromFileString(string fileString)
    {
        var parts = fileString.Split('|');
        var date = DateTime.Parse(parts[0]);
        var prompt = parts[1];
        var response = parts[2];
        return new Entry(prompt, response, date);
    }
}

public class Entry : NewBaseType
{
    public string Prompt { get; }
    public string Response { get; }
    public DateTime Date { get; }

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Date.ToString("g")}: {Prompt}\n{Response}\n";
    }

    public string ToFileString()
    {
        return $"{Date.ToString("o")}|{Prompt}|{Response}";
    }
}