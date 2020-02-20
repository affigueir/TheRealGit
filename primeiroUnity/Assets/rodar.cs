using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rodar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(9999999999, 999999999, 999999999));
        transform.Translate(new Vector3(0.99f, 0, 0.99f));    
    }
}
