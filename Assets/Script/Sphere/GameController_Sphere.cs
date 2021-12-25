using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    using Random = UnityEngine.Random;

public class GameController_Sphere : MonoBehaviour
{
    [SerializeField] ExplosionTrigger _explosion_Up;
    [SerializeField] Explosion _explosion_Down;
    [SerializeField] List<Rigidbody> _objects;
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
        if (currentTime <= 0)
        {
         // _explosion_Up.Boom();
          //  _explosion_Down.MasBoom(_objects);
            currentTime = timeToExplosion;
        }
    }






  



}