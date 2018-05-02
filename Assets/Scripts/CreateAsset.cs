using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "自定义资源.asset", menuName = "菜单/子项0")]
public class CreateAsset : ScriptableObject {

	//创建文件必须以 .asset 结尾

	public string Name = "自定义资源";

	public Vector3[] Pos = new Vector3[10];

}
