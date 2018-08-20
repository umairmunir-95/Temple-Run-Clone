using UnityEngine;
using System.Collections;

public class gamecontrol : MonoBehaviour 
{
	float timeRemaining = 10;
	float timeExtension = 3f;
	float timeDeduction = 5f;
	float totalTimeElapsed = 0;
	float score=0f;
	public bool isGameOver = false;
	
	void Start()
	{
		Time.timeScale = 1;  
	}
	
	void Update () 
	{ 
		if(isGameOver)
			return;
		totalTimeElapsed += Time.deltaTime;
		score = totalTimeElapsed*100;
		timeRemaining -= Time.deltaTime;
		if(timeRemaining <= 0){
			isGameOver = true;
		}
	}
	
	public void PowerupCollected()
	{
		timeRemaining += timeExtension;
	}
	public void AlcoholCollected()
	{
		timeRemaining -= timeDeduction;
	}
	
	
	void OnGUI()
	{
		GUIStyle guiStyle = new GUIStyle(); 
		guiStyle.fontSize = 20;
		guiStyle.normal.textColor = Color.green;
		if(!isGameOver)    
		{
			GUI.Label(new Rect(10, 10, Screen.width/5, Screen.height/6),"TIME LEFT: "+((int)timeRemaining).ToString(),guiStyle);
			GUI.Label(new Rect(Screen.width-(Screen.width/6), 10, Screen.width/6, Screen.height/6), "SCORE\n "+((int)score).ToString(),guiStyle);
		}
		else
		{
			Time.timeScale = 0;
			GUI.Box(new Rect(Screen.width/4, Screen.height/4, Screen.width/2, Screen.height/2), "GAME OVER\nYOUR SCORE: "+(int)score);
			if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+Screen.height/10+10, Screen.width/2-20, Screen.height/10), "RESTART"))
			{
				Application.LoadLevel(Application.loadedLevel);
			}
			if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+2*Screen.height/10+10, Screen.width/2-20, Screen.height/10), "Quit"))
			{
				Application.Quit();
			}
		}
	}
	/*float timeRemaining = 10;
	float timeExtension = 2f;
	float timeDeduction = 2f;
	float totalTimeElapsed = 0;
	float score=0f;
	public bool isGameOver = false;
	
	void Start()
	{
		Time.timeScale = 1;  
	}
	
	void Update () 
	{ 
		if (isGameOver)
						Time.timeScale = 0;

		totalTimeElapsed += Time.deltaTime;
		score = totalTimeElapsed*100;
		timeRemaining -= Time.deltaTime;
		if(timeRemaining <= 0){
			isGameOver = true;
		}
	}
	
	public void PowerupCollected()
	{
		timeRemaining += timeExtension;
	}
	public void AlcoholCollected()
	{
		timeRemaining -= timeDeduction;
	}

	
	void OnGUI()
	{
		GUIStyle guiStyle = new GUIStyle(); 
		guiStyle.fontSize = 20;
		guiStyle.normal.textColor = Color.green;
		if(!isGameOver)    
		{
			GUI.Label(new Rect(10, 10, Screen.width/5, Screen.height/6),"TIME LEFT: "+((int)timeRemaining).ToString(),guiStyle);
			GUI.Label(new Rect(Screen.width-(Screen.width/6), 10, Screen.width/6, Screen.height/6), "SCORE: \n"+((int)score).ToString(),guiStyle);
		}
		else
		{
			isGameOver=true;
			GUI.Box(new Rect(Screen.width/4, Screen.height/4, Screen.width/2, Screen.height/2), "GAME OVER\nYOUR SCORE: \n"+(int)score);
			if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+Screen.height/10+10, Screen.width/2-20, Screen.height/10), "RESTART"));
			{
				Application.LoadLevel(Application.loadedLevel);
			}
			if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+2*Screen.height/10+10, Screen.width/2-20, Screen.height/10), "Quit"))
			{
				Application.Quit();
			}
		}
	}*/
}
