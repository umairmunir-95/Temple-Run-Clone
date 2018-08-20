using UnityEngine;
using System.Collections;

public class nextLevel : MonoBehaviour
{
	public void OnClickPlay()
	{
		Application.LoadLevel("level");
	}
}
