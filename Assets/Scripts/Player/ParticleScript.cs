using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    ParticleSystem ParticleEmitter;

    // Start is called before the first frame update
    void Start()
    {
        ParticleEmitter = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("inofsdionfoisdn");
    }
}
