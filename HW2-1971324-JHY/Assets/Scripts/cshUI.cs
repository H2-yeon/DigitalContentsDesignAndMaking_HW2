using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshUI : MonoBehaviour
{
    /*public void SetForceAll()
    {
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("SelectableObj");
        for(int i = 0; i < boxes.Length; i++)
        {
            DestroyObject(boxes[i]);
        }

    }*/

    /*public void Delete(){
        GameObject[] ball = GameObject.FindGameObjectsWithTag("SelectableObj");
        for(int i = 0; i < ball.Length; i++)
        {
            DestroyObject(ball[i]); 
        }        
    }*/
    public GameObject Ball;
    public void Add(){
        GameObject[] ball = GameObject.FindGameObjectsWithTag("SelectableObj");
        for(int i = 0; i < ball.Length; i++)
        {
            DestroyObject(ball[i]); 
        } 
        Instantiate(Ball, new Vector3(0,1,-8), Quaternion.identity);
    }
}


