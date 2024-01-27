using System;

public class Word
{
    private string _text;

    private bool _isHidden;

    public Word(string text){
        _text = text;
    }

    public void Hide(){
        //Loop through word list and replace??
        foreach()
    }

    public void Show(){
        _isHidden = false;
    }

    public bool IsHidden(){
        if (_isHidden == true){
            return true;
        } else {
            return false;
        }
    }

    public string GetDisplayText(){

    }
}

