using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stages : MonoBehaviour
{

    public string sceneName;
    public int stage;
	public void SelectStage(){
		switch (stage)
        {
            case 1:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
                break;
            case 2:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
                break;

            case 3:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
                break;

            case 4:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
                break;
            case 5:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
                break;
            case 6:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
                break;

            case 7:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
                break;

            case 8:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
                break;

            case 9:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
                break;
            case 10:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
                break;

            case 11:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
                break;

            case 12:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
                break;
        }
	}
}
