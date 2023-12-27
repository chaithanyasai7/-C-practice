using System;


class VIRAT
{
    public void player()
    {
        Console.WriteLine("virat is from RCB");
    }

    public void play()
    {
        Console.WriteLine("virat is playing");
    }
}


class Rohit : VIRAT
{
    public void powerplay()
    {
        Console.WriteLine("rohit is hitting boundaries");
    }

    public void deathovers()
    {
        Console.WriteLine("rohit is made century");
    }
}

