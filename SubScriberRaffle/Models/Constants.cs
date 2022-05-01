using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubScriberRaffle.Models;
public class Constants
{
    private static readonly string apiKey;
    public static string ApiKey = apiKey ??= File.ReadAllText("C:\\youtube_key.txt");



    public const string VideoId = "KXtb6naWdMI";
    public const string LocalImageDir = "UserImages";
}
