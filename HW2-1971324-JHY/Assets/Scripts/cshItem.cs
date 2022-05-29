using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshItem : MonoBehaviour
{
    public GameObject Item;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 4.0)
        {
            Instantiate(Item, new Vector3(Random.Range(-8.0f, 8.0f), 1.5f, Random.Range(-8.0f, 3.0f)), Quaternion.identity);
            time = 0.0f;
        }
        time += Time.deltaTime;
    }
}
