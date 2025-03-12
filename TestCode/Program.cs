using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

public class CardInfo_class
{
    public int cardRating = 0;
    public int cardStatType = 0;
    public float increasValue = 0f;
    public string statTypeString = "Is Class";
}

public struct CardInfo_struct
{
    public int cardRating;
    public int cardStatType;
    public float increasValue;
    public string statTypeString;


}

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();

            int Max = 100_000_000;
            CardInfo_class newObject = new CardInfo_class();
            CardInfo_struct newStruct;
            newStruct.cardRating = 0;
            newStruct.cardStatType = 0;
            newStruct.increasValue = 0f;
            newStruct.statTypeString = "Is Struct";

            stopwatch.Start();
            for (int i = 0; i < Max; ++i)
            {
                int cardRating = newObject.cardRating;
                int cardStatType = newObject.cardStatType;
                float increasValuec = newObject.increasValue;
                string statTypeString = newObject.statTypeString;

                newObject.cardRating += 1;
                newObject.cardStatType += 1;
                newObject.increasValue += 1;
                newObject.statTypeString += "a";
                int RemoveIndex = newObject.statTypeString.Count() - 1;
                newObject.statTypeString = newObject.statTypeString.Remove(RemoveIndex);
            }

            stopwatch.Stop();
            double ClassTime = stopwatch.Elapsed.TotalSeconds;

            stopwatch.Restart();
            for (int i = 0; i < Max; ++i)
            {
                int cardRating = newStruct.cardRating;
                int cardStatType = newStruct.cardStatType;
                float increasValuec = newStruct.increasValue;
                string statTypeString = newStruct.statTypeString;

                newStruct.cardRating += 1;
                newStruct.cardStatType += 1;
                newStruct.increasValue += 1;
                newStruct.statTypeString += "a";
                int RemoveIndex = newStruct.statTypeString.Count() - 1;
                newStruct.statTypeString = newStruct.statTypeString.Remove(RemoveIndex);
            }

            stopwatch.Stop();
            double StructTime = stopwatch.Elapsed.TotalSeconds;

            Console.WriteLine($"ClassTime : {ClassTime}");
            Console.WriteLine($"StructTime : {StructTime}");
        }
    }


}
