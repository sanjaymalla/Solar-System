using Unity.VisualScripting;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    [SerializeField]private int numberOfAsteroids = 100;
    [SerializeField] private float minRadius = 4.85f;
    [SerializeField] private float maxRadius = 5.15f;
    [SerializeField] private float spawnHeight = 0.2f;

    private void Start()
    {
        SpawnAsteroids();
    }

    private void SpawnAsteroids()
    {
        for (int i = 0; i < numberOfAsteroids; i++)
        {
            //Generate a random position within the radius range
            Vector3 spawnPosition = RandomPointInDonut(minRadius, maxRadius);

            //Adjust the height for variation
            spawnPosition.y += Random.Range(-spawnHeight, spawnHeight);

            //Select a random asteroid prefab from the array
            GameObject randomAsteroid = asteroidPrefabs[Random.Range(0,asteroidPrefabs.Length)];

            //Instantiate the selected asteroid prefab at a random position
            Instantiate(randomAsteroid, spawnPosition, Random.rotation);


        }
    }

    private Vector3 RandomPointInDonut(float innerRadius, float outerRadius)
    {
        //Random angle in radians
        float angle = Random.Range(0,Mathf.PI*2);

        //Random distance within the radius range
        float radius = Random.Range(innerRadius,outerRadius);

        //Convert polar coordinates to Cartesian coordinates
        float x = radius * Mathf.Cos(angle);
        float z = radius * Mathf.Sin(angle);

        return new Vector3(x, 0, z);
    }
}
