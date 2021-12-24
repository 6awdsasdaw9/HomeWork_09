using UnityEngine;

public class Man : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private AudioEvent explosionEvent;
    [SerializeField] AudioSource explosionAudioSource;
    private Man Enemy;
    
    private Animator anim;
    private Explosion arms;
    private string[] _state = { "Idle", "Walk", "Attak" };

    private void Awake()
    {
        anim = transform.GetComponent<Animator>();
        arms = transform.GetComponentInChildren<Explosion>();
        if (arms == null) Debug.Log("Arm_Null");
    }


    /// <summary>
    /// Переключение анимации
    /// </summary>
    /// <param name="NameState">Наименование действия</param>
    private void AnimState(string NameState)
    {
        for (int i = 0; i < _state.Length; i++)
        {
            if (NameState == _state[i]) anim.SetTrigger($"{_state[i]}");
            else anim.ResetTrigger($"{_state[i]}");
        }
    }

    public void Idle() => AnimState("Idle");

    public void Walk(Vector3 target)
    {
        transform.LookAt(target);
        AnimState("Walk");
    }
    public void  Attak(Man Enemy)
    {
        this.Enemy = Enemy;
        transform.LookAt(Enemy.transform);
        Enemy.transform.LookAt(transform);
        AnimState("Attak");
    }
      
    void Explosion()
    {
        arms?.Boom(Enemy);
        explosionEvent.Play(explosionAudioSource);
    }
}