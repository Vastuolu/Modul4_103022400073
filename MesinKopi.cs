using System;

public class MesinKopi
{
    private enum stateMesin
    {
        OFF,
        STANDBY,
        BREWING,
        MAINTENANCE
    }
    private stateMesin currentState = stateMesin.OFF;

    public MesinKopi()
    {
        Console.WriteLine("Mesin Kopi Dinyalakan. Status: "+currentState);
    }

    public void Jalankan()
    {
        bool firstRun = true;
        while (currentState != stateMesin.OFF || firstRun)
        {
            firstRun = false;
            Console.Write("Masukkan Perintah (OFF, Standby, Brewing, Maintenance): ");
            string command = Console.ReadLine().ToLower();
            switch (currentState)
            {
                case stateMesin.OFF:
                    if (command == "standby")
                    {
                        Console.WriteLine("Mesin Off berubah menjadi Standby");
                        currentState = stateMesin.STANDBY;
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
                    break;
                case stateMesin.STANDBY:
                    switch (command)
                    {
                        case "off":
                            Console.WriteLine("Mesin Standby berubah menjadi Off");
                            currentState = stateMesin.OFF;
                            break;
                        case "brewing":
                            Console.WriteLine("Mesin Standby berubah menjadi Brewing");
                            currentState = stateMesin.BREWING;
                            break;
                        case "maintenance":
                            Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
                            currentState = stateMesin.MAINTENANCE;
                            break;
                        default:
                            Console.WriteLine("Perubahan state tidak valid");
                            return;
                    }
                    break;
                case stateMesin.BREWING:
                    if (command == "standby")
                    {
                        Console.WriteLine("Mesin Brewing berubah menjadi Standby");
                        currentState = stateMesin.STANDBY;
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
                    break;
                case stateMesin.MAINTENANCE:
                    if (command == "standby")
                    {
                        Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
                        currentState = stateMesin.STANDBY;
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
                    break;
                default:
                    Console.WriteLine("Status mesin tidak dikenali");
                    return;
            }
        }
    }
}