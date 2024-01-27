using System;
using System.Collections.ObjectModel;

public class Reference
{
    private string _book;

    private int _chapter;

    private int _verse;

    private int _endVerse;

    //Placing this here in case it needs to mirror the fraction assignment
    public Reference(){
        _book = "";
        _chapter = 0;
        _verse = 0;
        _endVerse = 0;
    }
    public Reference(string book, int chapter ,int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter ,int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText(){
        Console.WriteLine()
    }
}