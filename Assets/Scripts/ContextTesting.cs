using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextTesting : MonoBehaviour {

	[ContextMenuItem("Reset", "ResetBiography")]
	[Multiline(8)]
	public string playerBiography = "";

	[ContextMenu("Do Something")]
	void DoSomething()
	{
		Debug.Log("Perform operation");
	}

	void ResetBiography()
	{
		playerBiography = "";
	}


}
