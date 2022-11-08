namespace Features.Shed.Upgrade
{
    public interface IUpgradeable
    {
        float Speed { get; set; }
        float JumpHeight { get; set; }
        void Restore();
    }
}