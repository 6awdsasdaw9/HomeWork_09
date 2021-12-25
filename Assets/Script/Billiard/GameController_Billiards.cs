using UnityEngine;

public class GameController_Billiards : MonoBehaviour
{
    [SerializeField] ScoreInfo _score;
   private void OnTriggerExit(Collider other) =>_score.AddCount();
}