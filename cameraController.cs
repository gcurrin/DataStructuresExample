using UnityEngine;

public class cameraController : MonoBehaviour{
    [Header("Camera")]
    public Transform target;
    public float smoothSpeed = 2.125f;
    public Vector3 offset = new Vector3(0,15,-10);

    // Update is called once per frame
    void Update(){
        transform.LookAt(target);
    }
    private void LateUpdate(){
        Vector3 desiredPositon = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPositon, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}