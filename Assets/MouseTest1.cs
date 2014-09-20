using UnityEngine;
using System.Collections;

public class MouseTest1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetMouseButtonDown(0))
			Debug.Log("Pressed left click.");
		if(Input.GetMouseButtonDown(1))
			Debug.Log("Pressed right click.");
		if(Input.GetMouseButtonDown(2))
			Debug.Log("Pressed middle click.");
		*/
		//Event e = Event.current;

		Debug.Log(Input.mousePosition);
	}
}
