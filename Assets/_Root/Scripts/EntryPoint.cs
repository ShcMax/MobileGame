using Profile;
using UnityEngine;

internal class EntryPoint : MonoBehaviour
{
    [Header("Initial Settings")]
    [SerializeField] private float _speedCar = 15f;
    [SerializeField] private float _jumpHeighCar;
    [SerializeField] private GameState InitialState = GameState.Start;

    [SerializeField] private Transform _placeForUi;

    private MainController _mainController;


    private void Start()
    {
        var profilePlayer = new ProfilePlayer(_speedCar,_jumpHeighCar, InitialState);
        _mainController = new MainController(_placeForUi, profilePlayer);
    }

    private void OnDestroy()
    {
        _mainController.Dispose();
    }
}
