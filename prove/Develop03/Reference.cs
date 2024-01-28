using System;
using System.Collections.ObjectModel;

public class Reference
{
    private string _book;

    private int _chapter;

    private int _verse;

    private int _endVerse;

    //first empty reference (if mirroring fraction.cs in paradigm) is not needed due to needing members
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
        //How do we check if the first or second reference gets used?
        //Do we check to make sure the endverse = 0 or null? Likely.

        //First Reference Check
        if (_endVerse == 0) {
            return($"{_book} {_chapter}:{_verse}");
        } else {
            //Second is checked by way of else
            return($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }

    }
}