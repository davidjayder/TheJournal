using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventHandler : MonoBehaviour {
	public Queue<BaseEvent> m_Events = new Queue<BaseEvent>();

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Pop off the top event in the Queue
		HandleEvent ();
	}

	public void QueueEvent(BaseEvent tempEvent) 
	{
		m_Events.Enqueue(tempEvent);
	}

	private void HandleEvent()
	{		
		if (m_Events.Count > 0) {
			if (m_Events.Peek ().GetType () == typeof(TextEvent)) {
				Debug.Log ("Found a text event");
				TextEvent tempEvent = (TextEvent)m_Events.Dequeue ();
				SampleGUI script = (SampleGUI)tempEvent.EventObject.GetComponent (typeof(SampleGUI));
				script.m_blnShowGUI = !script.m_blnShowGUI;
				script.m_strGUIText = tempEvent.strGUIText;
			}
		}
	}
}
