namespace Excercises.Chapter03
{
    public static class RiskFunc
    {
        public static Risk CalculateRiskProfile(dynamic age) => age < 60 ? Risk.Low : Risk.Medium;
    }
}