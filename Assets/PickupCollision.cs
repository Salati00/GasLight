using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCollision : MonoBehaviour
{
    public GameObject GameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Cube")
        {
            if(gameObject.transform.name == "SingleBolt")
            {
                KeepingScore.Score += 100;
            } else if (gameObject.transform.name == "MultiBolts")
            {
                KeepingScore.Score += 300;
            }
            Debug.Log("Hit the Nuts");
            Destroy(gameObject);
        }
    }
}
