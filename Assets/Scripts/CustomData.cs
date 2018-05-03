using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[PreferBinarySerialization]
public class CustomData : MonoBehaviour {

	public float[] lotsOfFloatData = new[]{1f, 2f, 3f};

	public byte[] lotsOfByteData = new byte[]{4, 5, 6};
}
