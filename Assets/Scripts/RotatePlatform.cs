using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    [SerializeField] private float speedRotation = 2f;
    void FixedUpdate()
    {
        transform.Rotate(0, 0, speedRotation, Space.Self);
    }
}
