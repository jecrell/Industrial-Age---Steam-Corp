namespace IndustrialAgeSteamCorp
{
    public interface ILeakable
    {
        float CurLeakRate();
        void AdjustLeakRate(float amt);
    }
}
