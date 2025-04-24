using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class Navigator : MonoBehaviour
{
   // this method will be called from the button's OnClick event
	public void LoadScene(string sceneName)
	{
	    SceneManager.LoadScene(sceneName);
	}
}
        
