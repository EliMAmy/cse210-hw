using System;

class Program
{
    static void Main(string[] args)
    {
        // Lista para almacenar videos
        List<Video> videos = new List<Video>();
        //VIDEO 1
        string author = "The Weeknd";
        string title = "Save Your Tears";
        int length = 240;
        string comment1 = "I'm a 69 year old and I love this song. It brings back 80' memories. Great song.";
        string username1 = "@1115asmara";
        string comment2 = "One day in 2021 I’ll make music with The Weeknd. Remember this comment✨";
        string username2 = "@SteezyKane";
        string comment3 = "Best song off the album imo. This song is like a powerful drug I can’t stop listening to it.";
        string username3 = "@deadpaul6415";

        Video video1 = new Video();

        video1._author = author;
        video1._title = title;
        video1._length = length;
        Comment newComment = new Comment();
        newComment._name = username1;
        newComment._text = comment1;
        video1.AddComment(newComment);
        Comment newComment1 = new Comment();
        newComment1._name = username2;
        newComment1._text = comment2;
        video1.AddComment(newComment1);
        Comment newComment2 = new Comment();
        newComment2._name = username3;
        newComment2._text = comment3;
        video1.AddComment(newComment2);
        videos.Add(video1);

        //VIDEO 2
        string author2 = "Boney M";
        string title2 = "Rasputin";
        int length2 = 269;
        string comment4 = "43 years later and the floor is still vibrating from all that dancing..";
        string username4 = "@-Omar_";
        string comment5 = "Can we just appreciate the fact that he literally only stopped moving once or twice throughout the whole thing he is really energetic";
        string username5 = "@yourbestfella";
        string comment6 = "Its crazy how many people come back to this everyday... this song is masterpiece!";
        string username6 = "@DeadHandX";

        Video video2 = new Video();

        video2._author = author2;
        video2._title = title2;
        video2._length = length2;
        Comment newComment3 = new Comment();
        newComment3._name = username4;
        newComment3._text = comment4;
        video2.AddComment(newComment3);
        Comment newComment4 = new Comment();
        newComment4._name = username5;
        newComment4._text = comment5;
        video2.AddComment(newComment4);
        Comment newComment5 = new Comment();
        newComment5._name = username6;
        newComment5._text = comment6;
        video2.AddComment(newComment5);
        videos.Add(video2);

        //VIDEO 3
        string author3 = "Lady Gaga, Bruno Mars";
        string title3 = "Die With A Smile";
        int length3 = 252;
        string comment7 = "Impresionante junte de estos 2 grandes artistas del género pop. Pues debo decir que si me encantó está canción . Estuvo de maravilla";
        string username7 = "@doblatinofilm8163";
        string comment8 = "ESTAS CANCIONES TE AYUDAN A APRENDER INGLES ES LO BUENOface-green-smilingface-blue-wide-eyesface-blue-smilingface-blue-smilingface-blue-smilingface-blue-smilingface-blue-smiling";
        string username8 = "@ViridianaTapiaGonzalez";
        string comment9 = "Tengo 54 años. Y. Ya pensaba. Que. Las. Grandes. Canciones. Yaestaban hechas. Y estos dos. Sacuden al mundo con esta belleza.   Lady gaga.  Tremenda artista.   Gracias por ser. Como eres. Lady";
        string username9 = "@zacariascuevas2121";

        Video video3 = new Video();

        video3._author = author3;
        video3._title = title3;
        video3._length = length3;
        Comment newComment6 = new Comment();
        newComment6._name = username7;
        newComment6._text = comment7;
        video3.AddComment(newComment6);
        Comment newComment7 = new Comment();
        newComment7._name = username8;
        newComment7._text = comment8;
        video3.AddComment(newComment7);
        Comment newComment8 = new Comment();
        newComment8._name = username9;
        newComment8._text = comment9;
        video3.AddComment(newComment8);
        videos.Add(video3);

        foreach (Video onevideo in videos)
        {
            onevideo.DisplayAll();
        }



    }
}