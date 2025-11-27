using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RandomCubesGenerator : MonoBehaviour
{
    public int objectCount = 10;       
    public float delay = 1.0f;         
    public GameObject blockPrefab;     
    public Material[] materials;       

    private List<Vector3> positions = new List<Vector3>();
    private Bounds platformBounds;
    private int spawned = 0;

    void Start()
    {
        platformBounds = GetComponent<Renderer>().bounds;

        for (int i = 0; i < objectCount; i++)
        {
            float x = Random.Range(platformBounds.min.x, platformBounds.max.x);
            float z = Random.Range(platformBounds.min.z, platformBounds.max.z);
            float y = platformBounds.max.y + 1.0f;

            positions.Add(new Vector3(x, y, z));
        }

        StartCoroutine(GenerateObjects());
    }

    IEnumerator GenerateObjects()
    {
        while (spawned < positions.Count)
        {
            GameObject go = Instantiate(blockPrefab, positions[spawned], Quaternion.identity);

            if (materials.Length > 0)
            {
                Material randomMat = materials[Random.Range(0, materials.Length)];
                go.GetComponent<Renderer>().material = randomMat;
            }

            spawned++;
            yield return new WaitForSeconds(delay);
        }
    }
}
