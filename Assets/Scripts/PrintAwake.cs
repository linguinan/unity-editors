using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PrintAwake : MonoBehaviour {

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		Debug.Log("Awake");
	}

	// Use this for initialization
	void Start () {
		Debug.Log("Editor causes this Start");
	}
	
	// Update is called once per frame
	void Update () {
		// Debug.Log("Editor causes this Update");
	}

	[RuntimeInitializeOnLoadMethod]
	static void OnRuntimeMethodLoad()
	{
		Debug.Log("场景加载和游戏运行后");
	}

	[RuntimeInitializeOnLoadMethod]
	static void OnSecondRuntimeMethodLoad()
	{
		Debug.Log("SecondMethod场景加载和游戏运行后");
	}


}
