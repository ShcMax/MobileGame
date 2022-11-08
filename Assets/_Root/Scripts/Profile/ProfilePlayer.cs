using Game.Car;
using Tool;

namespace Profile
{
    internal class ProfilePlayer
    {
        public readonly SubscriptionProperty<GameState> CurrentState;
        public readonly CarModel CurrentCar;
        


        public ProfilePlayer(float speedCar, float jumpHeighCar, GameState initialState) : this(speedCar, jumpHeighCar)
        {
            CurrentState.Value = initialState;
        }

        public ProfilePlayer(float speedCar, float jumpHeighCar)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            CurrentCar = new CarModel(speedCar, jumpHeighCar);
        }
    }
}
