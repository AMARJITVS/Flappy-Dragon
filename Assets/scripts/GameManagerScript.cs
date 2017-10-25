using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    public int myScore;
    public static Text myScoreGUI;
    public GameObject a;
    public Transform obstacle, obstacle1;
    // Use this for initialization
    void Start() {
        if(ScoreScript.a==true)
        {
            DontDestroyOnLoad(a);
            myScoreGUI = GameObject.Find("Text1").GetComponent<Text>();
        }
     
            
       
        myScore = 0;

       
        myScoreGUI.enabled = true;
       
        InvokeRepeating("ObstacleSpawner", .5f, 1.8f);
       
    }
	public void GmAddScore()
    {
        myScore++;
        myScoreGUI.text = myScore.ToString();
        
    }
    void ObstacleSpawner()
    {
        int rand = Random.Range(0, 2);
        float Obstacle1MinY = 1f,
        Obstacle1MaxY= 6f,
        ObstacleMinY = -6f,
        ObstacleMaxY = -1f;

        switch(rand)
        {
            case 0:
                Instantiate(obstacle, new Vector2(9f, Random.Range(ObstacleMinY, ObstacleMaxY)), Quaternion.identity);
                break;
            case 1:
                Instantiate(obstacle1, new Vector2(9f, Random.Range(Obstacle1MinY, Obstacle1MaxY)), Quaternion.identity);
                break;

        }
    }
 
    // Update is called once per frame
    void Update () {
	
	}
}
