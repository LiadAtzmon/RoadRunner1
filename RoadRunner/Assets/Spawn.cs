using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public GameObject Obstacle;
    
    
    List<Vector3> Positions = new List<Vector3>();
    List<GameObject> Obstacles = new List<GameObject>(); 

    void Start () {

        int f = 0;
        transform.Translate(Vector3.right);
        
        for (int i = 0; i < 1000; i = i + 5)
        {
            
            Positions.Add(new Vector3(Random.Range(0.5f, 6.5f),0, i)); // <-------------------------
            //Give the f Obstacle in the Obstacles list The Transform (Vector3) of the line above-- |
            f = f + 1;
        }
        Debug.Log(Positions.Count);
        foreach (GameObject item in Obstacles)
        {
         
        }

        //Vector3 position = new Vector3(Random.Range(0.5f, 6.5f), 0, Random.Range(0.5f, 6.5f));
        //Instantiate(Obstacle, position, Quaternion.identity);


    }

    // Update is called once per frame
    void Update () {
        //i = i + 1;


    }
}
