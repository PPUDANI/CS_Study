using System.Diagnostics;

public enum CARD_RATING
{
    BRONZE,
    SILVER,
    GOLD,
    DIAMOND,
    NONE
}

namespace Random
{
    internal class Program
    {
        static int Gold = 10;
        static int Silver = 39;
        static int Bronze = 50;

        static int GetCardRating(int Seed)
        {
            int CurRange = 0;

            CurRange += Bronze;
            if (Seed < CurRange)
            {
                return 0;
            }

            CurRange += Silver;
            if (Seed < CurRange)
            {
                return 1;
            }

            CurRange += Gold;
            if (Seed < CurRange)
            {
                return 2;
            }

            return 3;
        }

        static void Main(string[] args)
        {
            System.Random Inst = new System.Random();
            List<int> Ratings = new List<int> { 0, 0, 0 };
            Dictionary<CARD_RATING, int> NumOfApperance = new Dictionary<CARD_RATING, int>();
            NumOfApperance.Add(CARD_RATING.BRONZE, 0);
            NumOfApperance.Add(CARD_RATING.SILVER, 0);
            NumOfApperance.Add(CARD_RATING.GOLD, 0);
            NumOfApperance.Add(CARD_RATING.DIAMOND, 0);

            int Num = 1_000_000_000;
            for (int i = 0; i < Num; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    Ratings[j] = GetCardRating(Inst.Next(0, 100));
                }
                ++NumOfApperance[(CARD_RATING)Ratings.Max()];
            }
            
            foreach(KeyValuePair<CARD_RATING, int> pair in NumOfApperance)
            {
                Console.WriteLine($"{pair.Key}'s Prob : {(float)pair.Value / (float)Num * 100}%");
            }

            
        }


    }
}
