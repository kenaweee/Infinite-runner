using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class sphere : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public int movespeed = 10;
    public int jump = 500;
    public Vector3 userDirection = Vector3.right;
    float c;
    bool onground = true;
    public  int health = 5;
    int ability = 10;
     int score = 0;
    public TMP_Text ts;
    public TMP_Text th;
    public TMP_Text tb;
    public int steer = 50;
    string temp;
    bool activateability = false;

    public bool GameIsPaused = false;
  bool GameIsOver = false;
    public GameObject pausemenuUI;
    public GameObject gameoverUI;
    public GameObject inputmenuUI;
    public TMP_Text scoretext;
    bool invincible = false;

    public AudioSource collisionaudio;
    public AudioSource collectaudio;

   // public Joystick joystick;


    // Start is called before the first frame update
    void Start()
    {

        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j"))
        {
            ability++;

        }
        if (Input.GetKeyDown("k"))
        {

            ability--;
        }
        if (Input.GetKeyDown("g"))
        {
            health++;

        }
        if (Input.GetKeyDown("h"))
        {
            health--;

        }
        if (Input.GetKeyDown("l"))
        {
            if (invincible == false)
                invincible = true;
            else
                invincible = false;

        }

        if (Input.GetKeyDown("q"))
        {
            if (ability >= 5)
            {
                foreach (GameObject g in GameObject.FindGameObjectsWithTag("obstacle1"))
                {
                    // g.SetActive(false);
                    Destroy(g);
                }
                foreach (GameObject g in GameObject.FindGameObjectsWithTag("obstacle2"))
                {
                    // g.SetActive(false);
                    Destroy(g);
                }
                foreach (GameObject g in GameObject.FindGameObjectsWithTag("obstacle3"))
                {
                    // g.SetActive(false);
                    Destroy(g);
                }
                ability = ability - 5;
               

            }

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
                Pause();
        }


        if (health <= 0)
        {
            gameover();

        }
       

    }


    private void FixedUpdate()
    {
       transform.Translate(userDirection * movespeed * Time.deltaTime);

        float horizontalInput = Input.GetAxis("Horizontal");
      //  float horizontalInput = joystick.Horizontal;
        transform.Translate(new Vector3(0, 0, horizontalInput * -1) * movespeed * Time.deltaTime);
        // m_Rigidbody.AddForce(new Vector3(0, 0, horizontalInput * -1) * steer);
        //|| joystick.Vertical > .5f
        if (Input.GetKey("space") )
        {
            if (ability > 0)
            {
                if (onground == true)
                {
                    onground = false;
                    m_Rigidbody.AddForce(transform.up * jump);
                    ability--;
                }
            }
        }   
    }
    

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("obs1")&temp !="obstacle1")
        {

            score += 3;
            Destroy(other.transform.root.gameObject);
        }
        if (other.gameObject.CompareTag("obs2") & temp != "obstacle2")
        {
            score += 2;
            Destroy(other.transform.root.gameObject);
        }
        if (other.gameObject.CompareTag("obs3") & temp != "obstacle3")
        {
            score += 1;
            Destroy(other.transform.root.gameObject);
        }
        if (other.gameObject.CompareTag("passed"))
        {
            Destroy(other.transform.root.gameObject, 1);
        }
        
        ts.text = "score: " + score ;
        scoretext.text = "Your score is " + score;

    }
    void OnCollisionEnter(Collision collision)
    {
        temp = collision.gameObject.tag;
        
        if (collision.gameObject.CompareTag("theroad"))
        {
            onground = true;

        }


        if (collision.gameObject.tag == "ability")
        {
            collectaudio.Play();
            if(ability<10)
            ability = ability + 1;
            Destroy(collision.gameObject);

        }
        else if (collision.gameObject.tag == "health")
        {
            collectaudio.Play();
            if (health < 5)
                health++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "obstacle1")
        {
            collisionaudio.Play();
            if (invincible == false)
            {
                if (health <= 1)
                    health = 0;
                else
                    health--;
            }
            Destroy(collision.gameObject);

        }
        else if (collision.gameObject.tag == "obstacle2")
        {
            collisionaudio.Play();
            if (invincible == false)
            {
                if (health <= 2)
                    health = 0;

                else
                    health = health - 2;
            }
            Destroy(collision.gameObject);
            // Debug.Log(health + "");

        }
        else if (collision.gameObject.tag == "obstacle3")
        {
            collisionaudio.Play();
            if (invincible == false)
            {
                if (health <= 3)
                    health = 0;

                else
                    health = health - 3;
            }
            Destroy(collision.gameObject);
        }


        th.text = "health: " + health;
        tb.text = "ability: " + ability;

    }
    public void Resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPaused = false;

    }
    void Pause()
    {


        pausemenuUI.SetActive(true);
        Time.timeScale = 0.0f;
        GameIsPaused = true;


    }
    public void restartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //pausemenuUI.SetActive(false);
       // gameoverUI.SetActive(false);
        GameIsOver = false;
        Time.timeScale = 1.0f;
        GameIsPaused = false;

    }
    public void menu()
    {
       // pausemenuUI.SetActive(false);
        //gameoverUI.SetActive(false);
        GameIsPaused = false;
        GameIsOver = false;
       Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);


    }
    public void gameover()
    {
        health = 5;
       // ability = 0;
        
        //GameIsOver = false;
        gameoverUI.SetActive(true);
        inputmenuUI.SetActive(false);
        Time.timeScale = 0.0f;
        //score = 0;



    }
}


