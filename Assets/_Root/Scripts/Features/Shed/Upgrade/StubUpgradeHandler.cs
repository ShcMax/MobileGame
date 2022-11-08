namespace Features.Shed.Upgrade
{
    internal class StubUpgradeHandler : IUpgradeHandler
    {
        public static readonly IUpgradeHandler Default = new StubUpgradeHandler();

        public void Upgrade(IUpgradeable upgradable) { }
    }
}
