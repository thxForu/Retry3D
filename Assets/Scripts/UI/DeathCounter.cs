using TMPro;
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI deathCounterText;
    private int deathCounter;
    
    private void Start()
    {
        deathCounter = PlayerPrefs.HasKey("Death") ? PlayerPrefs.GetInt("Death") : 0;
        deathCounterText.text = "Death: " + deathCounter.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("Death", deathCounter + 1);
        }
    }
}
