using UnityEngine;
using System.Collections;

public class moveHurdles : MonoBehaviour
{
	public float objectSpeed = -20f;
	
	
	void Update () {
		
		transform.Translate(new Vector3(0, objectSpeed, 0)*Time.deltaTime);
		
	}
}
