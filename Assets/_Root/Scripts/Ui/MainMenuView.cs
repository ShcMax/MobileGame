using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui
{
    public class MainMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonStart;
        [SerializeField] private Button _buttonSettings;


        public void Init(UnityAction startGame, UnityAction openSettings)
        {
            _buttonStart.onClick.AddListener(startGame);
            _buttonSettings.onClick.AddListener(openSettings);

        }
           

        public void OnDestroy()
        {
            _buttonStart.onClick.RemoveAllListeners();
            _buttonSettings.onClick.RemoveAllListeners();
        }
            
    }
}
