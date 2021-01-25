using UnityEngine;

public class MovePlatforms : MonoBehaviour
{
    [SerializeField] private float timeToArrive = 1.5f;
    [SerializeField] private float moveToY;
    [SerializeField] private float moveToX;
    
    private float timer;

    void Start()
    {
        LeanTween.moveY(gameObject, gameObject.transform.position.y + moveToY, timeToArrive).setLoopPingPong();
        LeanTween.moveX(gameObject, gameObject.transform.position.x + moveToX, timeToArrive).setLoopPingPong();
    }
}
