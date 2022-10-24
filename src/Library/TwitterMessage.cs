namespace CompAndDel;
using TwitterUCU;
using System;
//Ejercico 3
public class TwitterMessage
{
    public void Send(string path)
    {
        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter("text", path));
    }
}