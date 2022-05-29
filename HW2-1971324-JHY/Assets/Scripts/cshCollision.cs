using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshCollision : MonoBehaviour
{
    public int Iscore=0;
    public GameObject Particle;
    public GameObject Particle1;
/*    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "SelectableObj")
        {
            Destroy(collision.gameObject);
        }
    } */
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            Destroy(other.gameObject);
            Iscore=Iscore+1;
        }
    }

    void Update()
    {
        if (Iscore>=4){
            Particle.SetActive(true);
        }
        if (Iscore>=8){
            Particle1.SetActive(true);
        }
    }

}
