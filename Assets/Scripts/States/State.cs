using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interfaces { 
    public interface IState
    {
        void OnEnter();
        void OnUpdate();
        void OnExit();
    }

	public interface IGoap
	{
		HashSet<KeyValuePair<string, object>> getWorldState();
		HashSet<KeyValuePair<string, object>> createGoalState();
		void planFailed(HashSet<KeyValuePair<string, object>> failedGoal);
		void planFound(HashSet<KeyValuePair<string, object>> goal, Queue<Action> actions);
		void actionsFinished();
		void planAborted(Action aborter);
		bool moveAgent(Action nextAction);
	}
}