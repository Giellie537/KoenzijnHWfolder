using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class DelayEvent : MonoBehaviour
{

    public float WaitSeconds = 1f;
	public class StringEvent : UnityEvent<string>{}
	public UnityEvent delayedEvent;

	void Start () {
		
		Invoke("DelayonEvont",WaitSeconds);
	}


    void DelayEvont()
	{
		delayedEvent.Invoke();
		

	}
}


