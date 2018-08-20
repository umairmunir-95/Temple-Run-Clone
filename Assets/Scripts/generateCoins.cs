using UnityEngine;
using System.Collections;

public class generateCoins : MonoBehaviour
{
	public GameObject powerup;
	public GameObject obstacle;
	float timeElapsed = 0;
	float spawnCycle = 0.6f;
	bool spawnPowerup = true;
	
	void Update ()
	{
		timeElapsed += Time.deltaTime;
		if(timeElapsed > spawnCycle)
		{
			GameObject temp;
			if(spawnPowerup)
			{
				temp = (GameObject)Instantiate(powerup);
				Vector3 pos = temp.transform.position;
				temp.transform.position = new Vector3(Random.Range(0, 2), pos.y, pos.z);
			}
			else
			{
				temp = (GameObject)Instantiate(obstacle);
				Vector3 pos = temp.transform.position;
				temp.transform.position = new Vector3(Random.Range(-1, 2), pos.y, pos.z);
			}
			timeElapsed -= spawnCycle;
			spawnPowerup = !spawnPowerup;
		}
	}
}
