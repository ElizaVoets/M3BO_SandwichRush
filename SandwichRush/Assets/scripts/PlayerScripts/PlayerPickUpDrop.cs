using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{

    [SerializeField] private Transform playerCameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pickupDistance = 2f;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Left mouse button pressed");
            Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward,
                out RaycastHit raycastHit, pickupDistance);
        }
        
    }
}
