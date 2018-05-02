using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUITesting : MonoBehaviour {

	

	/// <summary>
	/// OnGUI is called for rendering and handling GUI events.
	/// This function can be called multiple times per frame (one call per event).
	/// </summary>
	[GUITarget(0, 1)]
	void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 300, 100), "Visible on TV and Wii U GamePad only");
	}
}
