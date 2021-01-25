using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    [SerializeField] private GameObject[] images;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject player;
    [SerializeField] private string sceneToLoad;
    private int tryCounter;

    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                        
            tryCounter++;
            if (tryCounter == 3)
            {
                print("Level completed");
                UnlockLevel();
                SceneToLoad(sceneToLoad);
            }
            else
            {
                player.transform.position = spawnPoint.position;
            }
            images[tryCounter-1].GetComponent<Animator>().SetBool("StartScaling",true);
            LeanTween.color(images[tryCounter-1].GetComponent<RectTransform>(),Color.green,.5f);
            

            print(tryCounter+" completed try");
        }
    }

    private void UnlockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        
        if (currentLevel >= PlayerPrefs.GetInt("UnlockLevel"))
        {
            PlayerPrefs.SetInt("UnlockLevel", currentLevel + 1);
        }
    }

    public void SceneToLoad(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
