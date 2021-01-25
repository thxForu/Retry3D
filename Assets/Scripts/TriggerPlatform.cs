using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{
    [SerializeField] private float timeToDrop;
    
    private float timer;
    private Animator twitching;

    void Start()
    {
        twitching = GetComponent<Animator>();
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            twitching.SetBool("StartTwitching",true);

            timer += Time.deltaTime;
            if (timer>=timeToDrop)
            {
                Destroy(gameObject, 1f);
            }
        }
    }
    private void OnCollisionExit()
    {
        if (timer <= timeToDrop)
        { 
            twitching.SetBool("StartTwitching",false);
            timer = 0;
        }
    }
}
