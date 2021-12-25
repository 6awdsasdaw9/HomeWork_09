using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabitySphere : MonoBehaviour
{
 

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().useGravity = false;
        
    }
    private void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().useGravity = true;    
        
    }

}
