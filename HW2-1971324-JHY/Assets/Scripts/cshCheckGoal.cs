using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshCheckGoal : MonoBehaviour
{
    public int score=0;
    public Text t;
    public GameObject Ball;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SelectableObj")
        {
            Destroy(other.gameObject);
            score=score+1;
            t.GetComponent<Text>().text = "Score = "+score;
            Instantiate(Ball, new Vector3(0,1,-8), Quaternion.identity);
        }
    }
}
