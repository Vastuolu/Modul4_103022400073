using System;

public class KodePaket
{

    private static Dictionary<string, string> kodePaket = new Dictionary<string, string>{
        { "Basic", "P201"},
        {"Standard", "P202"},
        {"Premium", "P203"},
        {"Unlimited", "P204"},
        {"Gaming", "P205"},
        {"Streaming", "P206"},
        {"Family", "P207"},
        {"Business", "P208"},
        {"Student", "P209"},
        {"Traveler", "P210" }
    };

    public static string getKodePaket(string namaPaket)
    {
        string kodeProduk = "";
        kodePaket.TryGetValue(namaPaket, out kodeProduk);
        return kodeProduk;
    }
}