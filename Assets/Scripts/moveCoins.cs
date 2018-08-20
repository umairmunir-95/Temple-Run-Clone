using UnityEngine;
using System.Collections;

public class moveCoins : MonoBehaviour
{
	public float objectSpeed = -20f;
	void Start ()
	{
		
	}
	void Update () 
	{
		transform.Translate(new Vector3(0, 0, objectSpeed)*Time.deltaTime);
	}
}
