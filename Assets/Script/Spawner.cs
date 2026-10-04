using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject platform;
    public GameObject brain;
    void Start()
    {
        SpawnPlatform();
        SpawnBrain();
    }

        public void SpawnPlatform()
        {
            Instantiate(platform);
        }
        
        public void SpawnBrain()
        {
            Instantiate(brain);
        }
}
