using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    CameraCapture cameraCapture = new CameraCapture();
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StopCamera()
    {
        // cameraCapture.AddButtonOnClick2();
        Debug.Log($"{cameraCapture.AddButtonOnClick3(1)}");
    }
}
