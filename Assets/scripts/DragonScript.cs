using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DragonScript : MonoBehaviour
{
    private AudioSource audioSource;

    private Rigidbody2D myRigidBody;
    private Animator myAnimator;
    private float jumpforce;
    public bool isAlive;
    public int a;
    
    // Use this for initialization
    void Start()
    {

        isAlive = true;

        myRigidBody = gameObject.GetComponent<Rigidbody2D>();
        myAnimator = gameObject.GetComponent<Animator>();

        jumpforce = 10f;
        myRigidBody.gravityScale = 0f;
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.Play();
       
    }

    // Update is called once per frame
    void Update()
    {

        if (isAlive)
        {
            if (Input.GetMouseButton(0))
            {
                Flap();
            }
            CheckIfDragonVisibleOnScreen();
        }

    }
    void Flap()
    {
        myRigidBody.gravityScale = 5f;
        myRigidBody.velocity = new Vector2(0, jumpforce);

        myAnimator.SetTrigger("Flap");

    }
    void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag=="Obstacle")
        {
            isAlive = false;

            audioSource.Stop();
           
            SceneManager.LoadScene("ExitScene");
           
           
        }
    }
    void CheckIfDragonVisibleOnScreen()
    {
        if(Mathf.Abs(gameObject.transform.position.y)> 4.84f)
        {
            isAlive = false;

           

        }
        if (Mathf.Abs(gameObject.transform.position.y)<-4.6f)
        {
            isAlive = false;

          

        }
        if (isAlive == false)
        {
            SceneManager.LoadScene("ExitScene");
            audioSource.Stop();

        }
    }
  
}