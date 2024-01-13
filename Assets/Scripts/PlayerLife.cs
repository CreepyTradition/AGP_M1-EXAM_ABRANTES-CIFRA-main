using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public bool hasDied;
    public bool health;
    // Start is called before the first frame update
    void Start()
    {
        hasDied = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerWall"))
        {
           // Updates so that player counted as Dead.
           hasDied = true;
           HeartsSystem heartsSystem = FindObjectOfType<HeartsSystem>();
           if (heartsSystem != null)
           {
              heartsSystem.TakeDamage(1);
           }
        }
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
