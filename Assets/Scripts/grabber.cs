using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabber : MonoBehaviour
{
    private GameObject armBody;
    private GameObject armPart1;

    // Start is called before the first frame update
    void Start()
    {
        armBody = GameObject.Find("ArmBody");
        armBody = GameObject.Find("ArmPart1");
    }

    private void grab()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
