using UnityEngine;

public class Zadanie5 : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject plane;
    public int cubeCount = 10;

    void Start()
    {
        float planeWidth = plane.transform.localScale.x * 10f;
        float planeLength = plane.transform.localScale.z * 10f;

        for (int i = 0; i < cubeCount; i++)
        {
            float x = Random.Range(-planeWidth / 2, planeWidth / 2) + plane.transform.position.x;
            float z = Random.Range(-planeLength / 2, planeLength / 2) + plane.transform.position.z;
            float y = 0.5f;

            Vector3 spawnPos = new Vector3(x, y, z);
            Instantiate(cubePrefab, spawnPos, Quaternion.identity);
        }
    }
}
