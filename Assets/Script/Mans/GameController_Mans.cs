using System.Collections.Generic;
using UnityEngine;

public class GameController_Mans : MonoBehaviour
{
    [SerializeField] Man SuperMan;
    [SerializeField] Transform Test;

    [SerializeField] List<Man> GoodMans;
    [SerializeField] List<Man> BadMans;
    [SerializeField] private ScoreInfo _score;

    private void Update()
    {
        if (BadMans.Count > 0)
        {
            if (Vector3.Distance(SuperMan.transform.position, BadMans[0].transform.position) > 1) ThisWalkTo(SuperMan, BadMans[0]);
            else if (Vector3.Distance(SuperMan.transform.position, BadMans[0].transform.position) <= 1) ThisAttakTo(SuperMan, BadMans);
        }
        else SuperMan.Idle();
        //if(GoodMans.Count != 0)
        //{


        //}
        //foreach (var GM in GoodMans)
        //{
        //    if (Vector3.Distance(GM.transform.position, SuperMan.transform.position) > 1) ThisWalkTo(GM, SuperMan);
        //    else GM.Idle();
        //}

    }


    void ThisWalkTo(Man First,Man Two)
    {
       First.Walk(Two.transform.position);
       First.transform.position = Vector3.MoveTowards(First.transform.position, Two.transform.position, Time.deltaTime * 3f);
    }

    void ThisAttakTo(Man First, List<Man> Enemy)
    {
      

            First.Attak(Enemy[0].gameObject);
      
               if (First == SuperMan) _score.AddCount();
             else _score.ResetCount();
            Enemy.Remove(Enemy[0]);

    }


}
