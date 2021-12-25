using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Score")]
public class ScoreInfo : ScriptableObject
{
    [SerializeField] private int _count;

    public delegate void ScoreDelegate();
    
    private event ScoreDelegate scoreEvent;
    public event ScoreDelegate ScoreEvent
    {
        add {
            scoreEvent -= value;
            scoreEvent += value; 
        }
        remove => ScoreEvent -= value;
    }
        

    public int GetCount => this._count;
    public void AddCount()
    {
        _count++;
        Raise();
    }
    public void ResetCount()
    {
        _count = 0;
        Raise();
    }
    public void DeductCount()
    {
        if (_count > 0)
        {
            _count--;
            Raise();
        }
        else return;

    }
    private void Raise()=> scoreEvent?.Invoke();
}






