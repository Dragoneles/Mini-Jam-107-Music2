namespace JC.Music
{
    public enum Interval
    {
        PerfectUnison = 0,

        MinorSecond = PerfectUnison + 1,
        MajorSecond = MinorSecond + 1,
        MinorThird = MajorSecond + 1,
        MajorThird = MinorThird + 1,
        PerfectFourth = MajorThird + 1,
        Tritone = PerfectFourth + 1,
        PerfectFifth = Tritone + 1,
        MinorSixth = PerfectFifth + 1,
        MajorSixth = MinorSixth + 1,
        MinorSeventh = MajorSixth + 1,
        MajorSeventh = MinorSeventh + 1,
        PerfectOctave = MajorSeventh + 1,
    }
}