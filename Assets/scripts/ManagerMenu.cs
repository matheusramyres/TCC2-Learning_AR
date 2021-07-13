using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
      
    }

	public void CallSceneWords(){
		SceneManager.LoadScene("02-Palavras",LoadSceneMode.Single);
	}

    public void CallSceneColors(){
		SceneManager.LoadScene("03-Cores",LoadSceneMode.Single);
	}

    public void CallSceneAnimals(){
		SceneManager.LoadScene("04-Animais",LoadSceneMode.Single);
	}

    public void BackMenu(){
		SceneManager.LoadScene("01-Menu",LoadSceneMode.Single);
	}
}
