using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    float randomX = 0;
    void Start()
    {
        randomX = Random.Range(-2.065f, 2.065f);
        transform.position = new Vector2(randomX, transform.position.y);
    }

}
