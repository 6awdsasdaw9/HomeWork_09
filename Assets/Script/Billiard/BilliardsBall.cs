using UnityEngine;

public class BilliardsBall : MonoBehaviour
{ 
    private Rigidbody _rigidbody;
    [SerializeField] Transform Point;

    private void Start()
    {
      _rigidbody = GetComponent<Rigidbody>();
      _rigidbody.AddForce(-30,0 , 0,ForceMode.Impulse);   
    }
}
