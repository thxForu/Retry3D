using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    [SerializeField] private GameObject Spray;
    [SerializeField] private Animator restartAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(Spray, other.transform.position, Quaternion.AngleAxis(-90,Vector3.right));
            StartCoroutine(LoadCurrentLevel());
        }
    }

    IEnumerator LoadCurrentLevel()
    {
        yield return new WaitForSeconds(0.8f);
        restartAnim.GetComponent<Animator>().SetBool("Restart",true);
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
