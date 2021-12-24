using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billiards : MonoBehaviour
{


    private Rigidbody _rigidbody;
    
    private float  _power =1;
    bool boom;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
   
    }



    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, Vector3.up, Time.deltaTime * _power);

    }

    private void OnCollisionEnter(Collision collision)
    {
       // Boom();
    }

    private void Boom()
    {
        //point = FindObjectOfType<Rigidbody>();

        //        Vector3 direction = point.transform.position - transform.position;

        //    point.AddForce(direction.normalized * _power , ForceMode.Impulse);
     
    }
}
