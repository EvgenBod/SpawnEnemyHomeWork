using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float _movingSpeed = 2;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _movingSpeed);
    }
}
