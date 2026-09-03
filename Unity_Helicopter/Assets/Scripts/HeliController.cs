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
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * _coreSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(-1.0f * Vector3.up * _coreSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _coreSpeed * Time.deltaTime);
        }
    }
}
