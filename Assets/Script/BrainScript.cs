using UnityEngine;

public class BrainScript : MonoBehaviour
{
    float randomX = 0;
    float randomY = 0;

    void Start()
    {
        randomX = Random.Range(-2.435f, 2.435f);
        randomY = (2 * Random.Range(-2, 3)) + 0.6f;
        transform.position = new Vector2(randomX, randomY);
    }
}
