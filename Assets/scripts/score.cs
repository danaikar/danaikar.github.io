using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    
    public Transform player;
    public TextMeshProUGUI scoreText;

    void Update() {
        scoreText.text = player.position.z.ToString("0");
    }
}
