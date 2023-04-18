using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : Interactable
{
    public GameObject AssignedObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The assigned object to this box is" + AssignedObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);

    }
}
