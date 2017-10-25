using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour {
    public Text myScoreGUI;
    public Text myScore;
    public static bool a=true;
    void Start()
    {
        myScoreGUI = GameObject.Find("Text1").GetComponent<Text>();
        myScore = GameObject.Find("Scores").GetComponent<Text>();
        if  (myScoreGUI.text=="")
            myScoreGUI.text = "0";
        myScore.text = myScoreGUI.text;
        myScoreGUI.text = "0";
        a = false;
        myScoreGUI.enabled = false;
    }
	
}
