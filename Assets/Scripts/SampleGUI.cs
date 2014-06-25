using UnityEngine;
using System.Collections;

public class SampleGUI : MonoBehaviour {
	public string m_strGUIText = "";
	public bool m_blnShowGUI = false;
	public EventHandler m_eventHandler;

	// Use this for initialization
	void Start () {
		m_eventHandler = (EventHandler)this.gameObject.GetComponent (typeof(EventHandler));
		Debug.Log("Getting event handler instance");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		if (GUI.Button (new Rect (10, 70, 50, 30), "Click")) {
			Debug.Log("About to queue event");
			m_eventHandler.QueueEvent (new TextEvent (this.gameObject, "Show this text"));
			Debug.Log("Event queued");
		}
		if (m_blnShowGUI) {
			GUI.TextArea(new Rect(10, 100, 200, 100), m_strGUIText);
		}
	}
}
