using System;

public class Scripture
{
    private Reference _reference = new Reference();

    private List<Word> _words = new List<Word>();


    public void Scripture(Reference reference, string text){
        //work with text seperators and iterate through text, and asign to words
    }
    public void HideRandomWords(int numberToHide)
    {
        //Make sure randomness runs off the numberToHide
    }
    public string GetDisplayText()
    {
        //make sure reference's display text is called, and then iterate through remaining words within the scripture class
    }

    public bool IsCompletelyHidden()
    {

    }
}

