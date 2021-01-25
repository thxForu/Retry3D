using UnityEngine;
using UnityEngine.UI;

public class LevelsManager : MonoBehaviour
{
    private int unlockLevel;
    [SerializeField] private Button[] _buttons;
    void Start()
    {
        unlockLevel = PlayerPrefs.GetInt("UnlockLevel")+1;
        for (int i = 0; i < _buttons.Length; i++)
        {
            _buttons[i].interactable = false;
        }

        for (int i = 0; i < unlockLevel; i++)
        {
            _buttons[i].interactable = true;
        }
    }
}
