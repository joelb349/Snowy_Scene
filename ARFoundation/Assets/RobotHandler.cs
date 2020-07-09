using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotHandler : MonoBehaviour {


    public ParticleSystem a_particleSystem;
// Start is called before the first frame update
void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            a_particleSystem.Play();
        }
    }
}
