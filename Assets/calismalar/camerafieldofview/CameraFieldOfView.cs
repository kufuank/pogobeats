using UnityEngine;

[RequireComponent(typeof(Camera))]

public class CameraFieldOfView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var localCamera = GetComponent<Camera>();
        localCamera.stereoTargetEye = StereoTargetEyeMask.None;

    }

    
}
