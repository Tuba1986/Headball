using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(9, 8, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
