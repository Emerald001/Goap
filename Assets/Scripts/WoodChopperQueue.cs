using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodChopperQueue : MonoBehaviour
{
    public GameObject NoteHolder;

    public List<Action> Actions = new List<Action>();

    public Queue<Action> Sequence = new Queue<Action>();

    private void Start() {
        //foreach (Action A in NoteHolder.transform.GetComponentInChildren<Action>()) {
        //    Actions.Add(A);
        //}
    }

    private List<Action> MakeRoad(Action actionToAchieve)
    {
        var currentAction = actionToAchieve;

        var bestList = new List<Action>();
        var bestCost = 0f;

        while (currentAction.Preconditions != null) {
            var currentCost = 0f;
            var list = new List<Action>();

            for (int j = 0; j < Actions.Count; j++)
            {
                if (Actions[j] == actionToAchieve)
                    continue;

                if (Actions[j].Effects != actionToAchieve.Preconditions)
                    continue;

                currentCost += Actions[j].actionCost;

            }
        }

        if(bestList.Count != 0)
            return bestList;
        return null;
    }
}
