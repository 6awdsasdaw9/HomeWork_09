using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] float _power;
    [SerializeField] float _radiys;
    Rigidbody[] rb;
    public void Boom(Man Enemy)
    {
        rb = Enemy.GetComponentsInChildren<Rigidbody>();
        float distance = Vector3.Distance(transform.position, Enemy.transform.position);
        if (distance < _radiys)
        {
            Debug.Log("BOOM");
            Vector3 direction = Enemy.transform.position - transform.position;
            rb[0].AddForce(direction.normalized * _power * (_radiys - distance));
        }
    }
}
