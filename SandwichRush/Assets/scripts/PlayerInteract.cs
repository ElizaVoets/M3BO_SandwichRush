using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float distance = 2f;
    [SerializeField]
    private LayerMask mask;
    private GameObject Obj;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //create a ray that can shoot outward from the camera
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;

        //if the ray hits something
        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if(hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Debug.Log(hitInfo.collider.GetComponent<Interactable>().promptMessage);
                
                Obj = hitInfo.collider.GetComponent<Box>().AssignedObject;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (Obj)
                    { 
                        Debug.Log(Obj + " has been spawned");
                        Instantiate(Obj, hitInfo.point, Quaternion.identity);

                    }

                }
            }
        }
    }
}
