using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action : MonoBehaviour
{
	HashSet<KeyValuePair<string, object>> preconditions = new HashSet<KeyValuePair<string, object>>();
    HashSet<KeyValuePair<string, object>> effects = new HashSet<KeyValuePair<string, object>>();

    public Action()
    {
        preconditions = new HashSet<KeyValuePair<string, object>>();
        effects = new HashSet<KeyValuePair<string, object>>();
	}
	public void doReset()
	{
		inRange = false;
		Target = null;
		reset();
	}

	//action cost
	public float actionCost;
	//in range
	public bool inRange;
	public bool isInRange()
	{
		return inRange;
	}
	public abstract bool requiresInRange();
	//target
	public GameObject Target;

	public abstract bool perform(GameObject agent);

	public abstract void reset();

	public abstract bool isDone();

	public void setInRange(bool inRange)
	{
		this.inRange = inRange;
	}

	public void addPrecondition(string key, object value)
	{
		preconditions.Add(new KeyValuePair<string, object>(key, value));
	}

	public void removePrecondition(string key)
	{
		KeyValuePair<string, object> remove = default(KeyValuePair<string, object>);
		foreach (KeyValuePair<string, object> kvp in preconditions)
		{
			if (kvp.Key.Equals(key))
				remove = kvp;
		}
		if (!default(KeyValuePair<string, object>).Equals(remove))
			preconditions.Remove(remove);
	}

	public void addEffect(string key, object value)
	{
		effects.Add(new KeyValuePair<string, object>(key, value));
	}

	public void removeEffect(string key)
	{
		KeyValuePair<string, object> remove = default(KeyValuePair<string, object>);
		foreach (KeyValuePair<string, object> kvp in effects)
		{
			if (kvp.Key.Equals(key))
				remove = kvp;
		}
		if (!default(KeyValuePair<string, object>).Equals(remove))
			effects.Remove(remove);
	}

	public HashSet<KeyValuePair<string, object>> Preconditions
	{
		get
		{
			return preconditions;
		}
	}

	public HashSet<KeyValuePair<string, object>> Effects
	{
		get
		{
			return effects;
		}
	}
}
