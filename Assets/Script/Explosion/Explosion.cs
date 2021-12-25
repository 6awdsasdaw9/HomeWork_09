using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] float _power;
    [SerializeField] float _radiys;
    Rigidbody[] rb;
    public void Boom(GameObject Enemy)
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

    public void MasBoom(List<Rigidbody> Objects)
    {
        for (int i = 0; i < Objects.Count; i++) Objects[i].AddForce(2, 2, 2, ForceMode.Impulse);
    }

}
