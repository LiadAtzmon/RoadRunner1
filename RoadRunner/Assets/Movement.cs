using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour { 
    public GameObject GameoverScreen;
    public GameObject StartScreen;
    public GameObject MyCanvas;
    public float LwallX;
    public float RwallX;
    Vector3 StartPosition = new Vector3(3.5f, 0, 0);
    int strikes = 5;
    int points = 0;
    bool coliding = true;
    public float acceleration;
    public float LeftTurnspeed;
    public float RightTurnspeed;
    //float CurrentTurnspeed;
    public float ForWardSpeed = 1f;
    public GameObject Life;
    public GameObject Points;
    public Light NLight;
    public GameObject PickUp;

    public void OnTriggerEnter(Collider other)
    {
        //GAMEOVER: --------------------------------------------------------
        if (strikes == 1)
        {
            
            GetComponentInChildren<TextMesh>().text = "GAME OVER";
            Time.timeScale = 0;
            //LeftTurnspeed = 0f;
            //RightTurnspeed = 0f;
            //CurrentTurnspeed = 0f;
            //ForWardSpeed = 0f;
            GameoverScreen.SetActive(true);
            //MyCanvas.GetComponentInChildren<Button>(true).gameObject.SetActive(true);
            NLight.intensity = 0.1f;

            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
            
        }
        //------------------------------------------------------------------


        //When Hit Obstacle: -----------------------------------------------
        if (other.tag == "Obstacle")
        {
            coliding = false;
            transform.position = StartPosition;
            
            Debug.Log("Ur Dead mun");
            strikes = strikes - 1;
            
            
        }
        //-----------------------------------------------------------------

        //PickUps: --------------------------------------------------------
        if (other.tag == "PickUp")
        {
            Destroy(other.gameObject);
            points = points + 350;
        }
        //-----------------------------------------------------------------
    }

    // Use this for initialization
    void Start () {
        
        coliding = true;
        strikes = 5;
        points = 0;
    }
    //----------------------------


    public void Restart()
    {
        GameoverScreen.SetActive(false);
        StartScreen.SetActive(true);

        transform.position = StartPosition;
        strikes = 5;
    }
    public void StartGame()
    {
         
    }

    // Update is called once per frame
    void Update () {
        //The Movement Limitation: ----------
        if (transform.position.x >= RwallX)
        {
            RightTurnspeed = 0;
        }
        else
        {
           
        }
        if (transform.position.x <= LwallX)
        {
            LeftTurnspeed = 0;
        }
        else
        {
           
        }
        //----------------------------------

        Life.GetComponent<Text>().text = "Life: " + strikes.ToString();
        Points.GetComponent<Text>().text = "Points: " + points.ToString();

        //Accelerating------------------------------
        if (coliding == true)
        {
            ForWardSpeed = ForWardSpeed + acceleration;
            LeftTurnspeed = LeftTurnspeed + (acceleration * (4.5f / 7));
            RightTurnspeed = RightTurnspeed + (acceleration * (4.5f / 7));


        }
        else
        {
            
            

        }
        //------------------------------------------


        // Right Moving
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * RightTurnspeed * 5 * Time.deltaTime);


        // Left Moving
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up * -LeftTurnspeed * 5 * Time.deltaTime);


        //Always Moving Forward
        transform.Translate(Vector3.forward * ForWardSpeed * Time.deltaTime);






















        //GameObject GAMEOVER = new GameObject();
        //GAMEOVER.AddComponent<TextMesh>();
        //GAMEOVER.GetComponent<TextMesh>().text = "GAMEOVER";

        // try-------------------------------------------------------
        //GameObject GAMEOVER = new GameObject();
        //GAMEOVER.AddComponent<TextMesh>();
        //GAMEOVER.GetComponent<TextMesh>().text = "GAMEOVER";
        // ->>>>>>  GAMEOVER.GetComponent<TextMesh>().transform.posi = Game <<<<<<<<<-
        //-------------------------------------------------------
    }
}
