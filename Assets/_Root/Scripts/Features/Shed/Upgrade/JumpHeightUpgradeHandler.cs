namespace Features.Shed.Upgrade
{
    internal class JumpHeightUpgradeHandler : IUpgradeHandler
    {
        private readonly float _jumpHeight;

        public JumpHeightUpgradeHandler(float jumpHeight) =>
            _jumpHeight = jumpHeight;

        public void Upgrade(IUpgradeable upgradable) =>
            upgradable.JumpHeight += _jumpHeight;
    }
}