using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Application.temporaryCachePath);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
        print("Update");
    }
    private void FixedUpdate()
    {
        //Debug.Log("FixedUpdate");
        print("FixedUpdate");
    }
    private void LateUpdate()
    {
        print("LateUpdate");
    }
}
