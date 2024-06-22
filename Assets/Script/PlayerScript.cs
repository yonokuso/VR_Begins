using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position,transform.forward, out hit))
        {
            //Debug.Log("오브젝트 인식");
            if(hit.transform.GetComponent<DoorBottomScript>() != null)
            {
                hit.transform.GetComponent<DoorBottomScript>().OnLook();
            }
        }
    }
}
