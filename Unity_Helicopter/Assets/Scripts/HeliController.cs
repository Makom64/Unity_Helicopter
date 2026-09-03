using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliController : MonoBehaviour
{
    [SerializeField] private float _coreSpeed;

    private void Update()
    {
        CoreMove();
    }
    
    private void CoreMove()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.up * _coreSpeed * Time.deltaTime;
        }
    }
}
