using System;

class Program
{
    static void Main(string[] args)
    {
        //making a list to add each video onto
        var listVideo = new List<Video>();

        // ------------ Video 1 ---------------
        Video newVideo1 = new Video("Basics of Programming", "John Snow", 600);
        newVideo1.addComment("Joseph Barrow", "I completely forgot about loops, thanks for the quick lesson!");
        newVideo1.addComment("Joseph Barrow", "I completely forgot about loops, thanks for the quick lesson!");
        newVideo1.addComment("Joseph Barrow", "I completely forgot about loops, thanks for the quick lesson!");
        
        listVideo.Add(newVideo1);

        // ------------ Video 2 --------------
        Video newVideo2 = new Video("Introduction to Chemical Reactions", "John Snow", 10000);
        newVideo2.addComment("Joseph Barrow", "I completely forgot about loops, thanks for the quick lesson!");
        newVideo2.addComment("Joseph Barrow", "I completely forgot about loops, thanks for the quick lesson!");
        newVideo2.addComment("Joseph Barrow", "I completely forgot about loops, thanks for the quick lesson!");

        listVideo.Add(newVideo2);

        // ------------ Video 3 --------------
        Video newVideo3 = new Video("Basics of Programming", "John Snow", 820);
        newVideo3.addComment("Joseph Barrow", "I completely forgot about loops, thanks for the quick lesson!");
        newVideo3.addComment("Joseph Barrow", "I completely forgot about loops, thanks for the quick lesson!");
        newVideo3.addComment("Joseph Barrow", "I completely forgot about loops, thanks");
    
        listVideo.Add(newVideo3);

        // ------------ Video 4 --------------
        Video newVideo4 = new Video("Basics of Programming", "John Snow", 600);
        newVideo4.addComment("Joseph Barrow", "I completely forgot about loops, thanks for the quick lesson!");
        newVideo4.addComment("Joseph Barrow", "I completely forgot about loops, thanks for the quick lesson!");
        newVideo4.addComment("Joseph Barrow", "I completely forgot about loops, thanks");

        listVideo.Add(newVideo4);

        // ---- Display Video List ----
        foreach(var v in listVideo)
        {
            v.DisplayVideoDetails();
            Console.WriteLine("");
        }
        
    }
}