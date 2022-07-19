using UnityEngine;

public class cameraFlow : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    void Update() {
        transform.position = player.position + offset;
    }
}
