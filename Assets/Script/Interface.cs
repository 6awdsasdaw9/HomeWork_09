
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Interface : MonoBehaviour
{
    [SerializeField] private Text _textscore;
    [SerializeField] private ScoreInfo _score;

   static private int _currentSceneIndex,_countScenesIndex;

    
    public void InfoUpdate() =>_textscore.text = ($"Score: {_score.GetCount}");
    private void Awake()
    {
        InfoUpdate();
       _score.ScoreEvent += InfoUpdate;
       
        _countScenesIndex = SceneManager.sceneCountInBuildSettings - 1;
        print("Max index" + _countScenesIndex);
    }

    public void LoadNextScene()
    {
            ++_currentSceneIndex;
        if (_currentSceneIndex > _countScenesIndex)
        {
            _currentSceneIndex = 0;
        }
        
        print("Next "+_currentSceneIndex);
        SceneManager.LoadScene(_currentSceneIndex);
    }
       

    public void LoadPreviousScene()
    {
        --_currentSceneIndex;
        if (_currentSceneIndex < 0) _currentSceneIndex = _countScenesIndex;

        print("Previous " + _currentSceneIndex);
        SceneManager.LoadScene(_currentSceneIndex);

    }

}