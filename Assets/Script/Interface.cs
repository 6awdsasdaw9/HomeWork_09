using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    [SerializeField] private Text _textscore;
    [SerializeField] private ScoreInfo _score;

    private void Awake()
    {
        InfoUpdate();
       _score.ScoreEvent += InfoUpdate;
    }
   
    public void InfoUpdate() =>_textscore.text = ($"Score: {_score.GetCount}");
}