using UnityEngine;
using System.Collections;

public class cloneDestroyer : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
	}
}
