using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public p1_scr movement;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo) {
        if(collisionInfo.gameObject.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
