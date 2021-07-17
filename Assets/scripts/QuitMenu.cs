using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class QuitMenu : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Escape)){
            Screen.orientation = ScreenOrientation.Portrait;
            SceneManager.LoadScene("01-Menu",LoadSceneMode.Single);
            
        }
    }
}
