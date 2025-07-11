using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        string surprise;

        // Video testVideo = new Video("testing");
        // testVideo.GetCommentCount();
        Video trogdor = new Video("Strong Bad Email #58 - Dragon", "homestarrunnerdotcom", 209);
        Comment trog1 = new Comment("FUN FACT: This email didn't originally have the Trogdor song in it. According to Matt and Mike's commentary in the SBEmail DVDs, Matt Chapman started singing it off the top of his head while making eggs, and The Brothers Chaps knew they had to put it in the email.", "AlexParr");
        Comment trog2 = new Comment("As a child, I didn't realize how funny 'put a top mark on a long V' was when he wanted to express 'draw a triangle'", "ArcherFaux");
        Comment trog3 = new Comment("I love how the Trogdor music video has the elaborate chiaroscuro shading over the drawings that Strong Sad did, implying Strong Bad forced his little brother to draw all of those assets.", "theotherther1");
        trogdor.AddComment(trog1);
        trogdor.AddComment(trog2);
        trogdor.AddComment(trog3);
        videoList.Add(trogdor);

        Video bouffant = new Video("BULBOUS BOUFFANT - The Vestibules - rotoscope animation", "Spencer James Parks", 290);
        Comment bouf1 = new Comment("A few minutes ago, someone said 'Gazebo,' so it was - of course - my pride and duty to introduce them to this masterpiece.", "ohkaygoplay");
        Comment bouf2 = new Comment("I just got a robo call which gave me the option of leaving a message on my state representative's answering machine. I happened to have this vid playing at the time. Guess what I did.", "infradog2589");
        Comment bouf3 = new Comment("TUBERCULOSIS.", "alexandra1131");
        bouffant.AddComment(bouf1);
        bouffant.AddComment(bouf2);
        bouffant.AddComment(bouf3);
        videoList.Add(bouffant);

        Video rickRoll = new Video("Rick Astley - Never Gonna Give You Up (Official Video) (4K Remaster)", "Rick Astley", 213);
        Comment rick1 = new Comment("can confirm: he never gave us up", "Youtube");
        Comment rick2 = new Comment("Nobody can fool me anymore with this, I now remember every letter and number of the link", "SilentMemer");
        Comment rick3 = new Comment("I didn't get rickrolled today, I just really enjoy this song", "CinematicCaptures");
        rickRoll.AddComment(rick1);
        rickRoll.AddComment(rick2);
        rickRoll.AddComment(rick3);
        videoList.Add(rickRoll);

        foreach (Video vid in videoList)
        {
            foreach (Comment comment in vid._commentList)
            {
                comment.DisplayComment();
            }
        }

        Console.WriteLine("Would you like a surprise? \n1: yes\n2: no");
        surprise = Console.ReadLine();
        if (surprise == "1")
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ&list=RDdQw4w9WgXcQ&start_radio=1",
                UseShellExecute = true
            });
        }
    }
}