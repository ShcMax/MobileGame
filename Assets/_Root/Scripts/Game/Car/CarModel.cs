using Features.Shed.Upgrade;
namespace Game.Car
{
    internal class CarModel: IUpgradeable 
    {
        private readonly float _defaultSpeed;
        private readonly float _defailtJumpHeight;

        public CarModel(float speed, float jumpHeight)
        {
            _defaultSpeed = speed;
            _defailtJumpHeight = jumpHeight;

            Speed = speed;
            JumpHeight = jumpHeight;
        } 
            

        public float JumpHeight { get; set; }

        public float Speed { get; set; }

        public void Restore()
        {
            Speed = _defaultSpeed;
            JumpHeight = _defailtJumpHeight;
        }
    }
}
