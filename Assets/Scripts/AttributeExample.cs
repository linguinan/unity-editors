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
	[Tooltip("Health值从0到100.")]
	public int health = 0;
	public int maxHealth = 100;

	[Header("防御 Settings")]
	public int shield = 0;
	public int maxShield = 0;

	[HideInInspector]
	public int Hide = 0;

	[Multiline(10)]
	public string str = "";

	[Range(0, 1000f)]
	public int speed;

	[Space(30)]//在检查器中添加一些间距。

	//This field gets serialized because it is public.
    public string firstName = "John";

    //This field does not get serialized because it is private.
    private int age = 40;

	//This field gets serialized even though it is private
    //because it has the SerializeField attribute applied
	[SerializeField]
	private bool hasHealthPotion = true;

	//如果文本大于可用区域，则会显示一个滚动条。
	[TextArea]
	public string DefaultTextArea;

	//指定TextArea的最小和最大行，并且字段将根据文本的大小进行扩展。
	[TextArea(4, 6)]
	public string LimitTextArea;

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		if(hasHealthPotion)
			Debug.Log("Person's first name: " + firstName + " Person's age: " + age);
	}



}
