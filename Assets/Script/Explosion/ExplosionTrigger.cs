using UnityEngine;
public class ExplosionTrigger : MonoBehaviour
{
    Explosion _explosion;
    private void Awake() => _explosion = GetComponentInChildren<Explosion>();
    private void OnTriggerEnter(Collider other)=>_explosion.Boom(other.gameObject);
}
    