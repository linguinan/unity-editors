using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//定该StateMachineBehaviour应仅实例化一次，并在所有Animator实例之间共享。
//此属性减少每个控制器实例的内存占用。
[SharedBetweenAnimators]
public class AttackBehaviour : StateMachineBehaviour {

	//更改一些成员变量，它将影响使用它的所有其他Animator实例

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Debug.Log("OnStateEnter");
	}
}
