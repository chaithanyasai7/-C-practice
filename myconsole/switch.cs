using System;

class SwitchExample
{
    public static void IPL(int Team)
    {
        switch (Team)
        {
            case 1:
                Console.WriteLine("RCB");
                break;
            case 2:
                Console.WriteLine("CSK");
                break;
            case 3:
                Console.WriteLine("MI");
                break;
            case 4:
                Console.WriteLine("PBKS");
                break;
            case 5:
                Console.WriteLine("SRH");
                break;
            case 6:
                Console.WriteLine("DC");
                break;
            case 7:
                Console.WriteLine("KKR");
                break;
            default:
                Console.WriteLine("Invalid team");
                break;
        }
    }
}
