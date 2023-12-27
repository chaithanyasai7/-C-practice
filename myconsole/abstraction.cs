using System;


abstract class Sport
{
    public abstract void Play();
}
class Football : Sport
{
    
    public override void Play()
    {
        Console.WriteLine("Playing football");
    }
}
class Basketball : Sport
{
    public override void Play()
    {
        Console.WriteLine("Playing basketball");
    }
}
