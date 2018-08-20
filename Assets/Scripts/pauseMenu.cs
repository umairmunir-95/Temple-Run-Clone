using UnityEngine;
using System.Collections;

public class pauseMenu : MonoBehaviour 
{
	public bool paused = false;
	private void Start()
	{
		Time.timeScale=1; 
	}
	
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) )
		{
			if (paused)
				paused = false;  
			else
				paused = true; 
		}
		
		if(paused)
			Time.timeScale = 0; 
		else
			Time.timeScale = 1;  
	}

	private bool flag=false;
	private bool showWindow=true;
	private void OnGUI()
	{
		GUIStyle guiStyle = new GUIStyle(); 
		guiStyle.fontSize = 20;
		guiStyle.normal.textColor = Color.green;
		if (paused)
		{
			if(showWindow)
			{
				GUI.Box(new Rect(Screen.width/4, Screen.height/4, Screen.width/2, Screen.height/2), "PAUSED");
				if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+Screen.height/10+10, Screen.width/2-20, Screen.height/10), "RESUME"))
				{
					paused = false;
				}
				
				if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+2*Screen.height/10+10, Screen.width/2-20, Screen.height/10), "RESTART"))
				{
					Application.LoadLevel(Application.loadedLevel);
				}
				if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+3*Screen.height/10+10, Screen.width/2-20, Screen.height/10), "Options"))
				{
					flag=!flag;
					showWindow=false;
				} 
				if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+4*Screen.height/10+10, Screen.width/2-20, Screen.height/10), "Quit"))
				{
					Application.Quit();
				}
			}
			if(flag)
			{
				GUI.Box(new Rect(Screen.width/4, Screen.height/4, Screen.width/2, Screen.height/2), "Selecet Your Choice!! ");
				if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+Screen.height/10+10, Screen.width/2-20, Screen.height/10), "Sound"))
				{
					if (AudioListener.pause == false)
						AudioListener.pause=true;
					else
						AudioListener.pause=false;

				}
				if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+2*Screen.height/10+10, Screen.width/2-20, Screen.height/10), "Back to main menu"))
				{
					flag=!flag;
					showWindow=true;
				}
			}
		}
	}
}
