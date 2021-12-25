using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    using Random = UnityEngine.Random;

public class GameController_Sphere : MonoBehaviour
{
    [SerializeField] Explosion _explosion;
    [SerializeField] Rigidbody _forceObject;
    [SerializeField] GameObject _gravitiZone;
    [SerializeField] GameObject _gravitiObject;

    [SerializeField] private float timeToExplosion,currentTime;

    private void Start()
    {

        currentTime = timeToExplosion;
    }

    private void Update()
    {

        currentTime -= Time.fixedDeltaTime;
        if (currentTime <= 0) _explosion.Boom(_gravitiObject);
    }





    public void boom()
    {

        currentTime = timeToExplosion;
        _forceObject.AddForce(0,5,0, ForceMode.Impulse);

    }




}