using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[HelpURL("https://linguinan.github.io/")]
public class AttributeExample : MonoBehaviour {

	//当使用此属性时，字段将不会立即返回一个新的值，直到用户按下enter或焦点离开该字段。
	[Delayed()]//用于在脚本中使float，int或string变量的属性被延迟。
	public string content;

	[Delayed()]
	public float percent;

	[Delayed()]
	public int count;

	[Header("生命 Settings")]
	public int health = 0;
	public int maxHealth = 100;

	[Header("防御 Settings")]
	public int shield = 0;
	public int maxShield = 0;

	[HideInInspector]
	public int Hide = 0;

	[Multiline(10)]
	public string str = "";


}
