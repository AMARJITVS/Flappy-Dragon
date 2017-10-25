using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartScript : MonoBehaviour {
    public Text myScore;
    public void NewStartGame(string start)
    {
       
        SceneManager.LoadScene(start);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
  
}
