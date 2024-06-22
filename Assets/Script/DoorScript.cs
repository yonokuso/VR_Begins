using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Vector3 targetP;
    public Vector3 BottomP;

    // Start is called before the first frame update
    void Start()
    {
        targetP = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetP, Time.deltaTime);
    }

    public void OpenDoor() // 다른 스크립트에 사용, public 잊지 말기
    {
        targetP = BottomP;
    }
}
