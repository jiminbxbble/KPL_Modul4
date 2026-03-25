using System;

public class Program
{
    public static void Main(string[] args)
    {
        KodePaket paket = new KodePaket();
        Console.WriteLine("Basic: " + paket.getKodePaket("Basic"));
        Console.WriteLine("Standard: " + paket.getKodePaket("Standard"));
        Console.WriteLine("Premium: " + paket.getKodePaket("Premium"));
        Console.WriteLine("Unlimited: " + paket.getKodePaket("Unlimited"));
        Console.WriteLine("Gaming: " + paket.getKodePaket("Gaming"));
        Console.WriteLine("Streaming: " + paket.getKodePaket("Streaming"));
        Console.WriteLine("Family: " + paket.getKodePaket("Family"));
        Console.WriteLine("Business: " + paket.getKodePaket("Business"));
        Console.WriteLine("Student: " + paket.getKodePaket("Student"));
        Console.WriteLine("Traveler: " + paket.getKodePaket("Traveler"));

        MesinKopi mesin = new MesinKopi();
        mesin.TriggerState(MesinKopi.Trigger.POWER_ON);
        mesin.TriggerState(MesinKopi.Trigger.START_BREW);
        mesin.TriggerState(MesinKopi.Trigger.FINISH_BREW);
        mesin.TriggerState(MesinKopi.Trigger.START_MAINTENANCE);
        mesin.TriggerState(MesinKopi.Trigger.FINISH_MAINTENANCE);
        mesin.TriggerState(MesinKopi.Trigger.POWER_OFF);

        Console.WriteLine();
        mesin.TriggerState(MesinKopi.Trigger.START_BREW);
    }
}