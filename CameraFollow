using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 4, -6); // offset
    public float smoothSpeed = 0.125f;

    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
        else
        {
            Debug.LogError("Player not found! Make sure the prefab is tagged correctly.");
        }
    }

    void FixedUpdate()
    {
        if (target == null)
        {
            Debug.LogError("Camera target not set!");
            return;
        }

        Vector3 desiredPosition = target.position + target.rotation * offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.LookAt(target);
    }

}