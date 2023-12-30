using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Destroy the coin after 5 seconds
        Destroy(gameObject, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
