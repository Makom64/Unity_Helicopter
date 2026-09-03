using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliController : MonoBehaviour
{
    [SerializeField] private float _coreSpeed;
    private const string HORIZON = "Horizontal";
    private float _coreTurn;
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
        
        if (Input.GetKey(KeyCode.D))
        {
            _coreTurn += Input.GetAxis(HORIZON) * _coreSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up * _coreTurn *  _coreSpeed * 5 * Time.deltaTime);
        }
        
        if (Input.GetKeyUp(KeyCode.D))
        {
            _coreTurn = 0;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            _coreTurn += Input.GetAxis(HORIZON) * _coreSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up *  _coreTurn * _coreSpeed * 5 * Time.deltaTime);
        }
        
        if (Input.GetKeyUp(KeyCode.A))
        {
            _coreTurn = 0;
        }
    }
}
