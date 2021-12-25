using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    using Random = UnityEngine.Random;

public class GameController_Sphere : MonoBehaviour
{
    [SerializeField] Explosion[] _explosion;
 
    [SerializeField] List<Rigidbody> _objects;

    [SerializeField] private float timeToExplosion,currentTime;
    private bool _estafet = true;

    private void Start()
    {

        currentTime = timeToExplosion;
        _explosion[1].transform.LookAt(_explosion[0].transform);
    }

    private void FixedUpdate()
    {
        currentTime -= Time.fixedDeltaTime;
        if (currentTime <= 0 && _estafet)
        {
            for (int i = 0; i < _objects.Count; i++) _explosion[0].Boom(_objects[i].gameObject);

            _estafet = false;
            currentTime = timeToExplosion;
        }

        if (currentTime < timeToExplosion / 2 && !_estafet)
        {
            for (int i = 0; i < _objects.Count; i++) { _explosion[1].Boom(_objects[i].gameObject); }
            _estafet = true;

        }
    }






  



}