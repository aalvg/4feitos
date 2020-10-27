using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    private Camera cam;
    public Transform playerTransform;
    public Transform LimitCamLeft, LimitCamRight, LimitCamUp, LimitCamDown;
    public float lerpF = 1.5f;
    public float speedCam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    void LateUpdate()
    {
        CameraController();
    }

    void CameraController()
    {
        float posCamX = playerTransform.position.x;
        float posCamY = playerTransform.position.y;

        if (cam.transform.position.x < LimitCamLeft.position.x && playerTransform.position.x < LimitCamLeft.position.x)
        {
            posCamX = LimitCamLeft.position.x;
        }
        else if (cam.transform.position.x > LimitCamRight.position.x && playerTransform.position.x > LimitCamRight.position.x)
        {
            posCamX = LimitCamRight.position.x;
        }
        if (cam.transform.position.y < LimitCamDown.position.y && playerTransform.position.y < LimitCamDown.position.y)
        {
            posCamY = LimitCamDown.position.y;

        }
        else if (cam.transform.position.y > LimitCamUp.position.y && playerTransform.position.y > LimitCamUp.position.y)
        {
            posCamY = LimitCamUp.position.y;

        }
        Vector3 posCam = new Vector3(posCamX, posCamY, cam.transform.position.z);
        cam.transform.position = Vector3.Lerp(cam.transform.position, posCam, speedCam * lerpF * Time.deltaTime);
    }
}
