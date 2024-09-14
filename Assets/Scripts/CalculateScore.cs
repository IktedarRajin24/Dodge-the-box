using TMPro;
using UnityEngine;

public class CalculateScore : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score;
    void Update()
    {

        if (FindObjectOfType<GameManager>().gameHasEnded == true)
        {
            score.text = "Game Over";
        }
        else
        {
            score.text = player.position.z.ToString("0");
        }
    }
}
