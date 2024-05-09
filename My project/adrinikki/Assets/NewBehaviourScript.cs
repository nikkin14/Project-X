using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject[] blockPrefabs;

    void Start()
    {
        SpawnRandomBlock();
    }

    void SpawnRandomBlock()
    {
        // Randomly choose a block prefab from the array
        int randomIndex = Random.Range(0, blockPrefabs.Length);
        GameObject blockPrefab = blockPrefabs[randomIndex];

        // Spawn the chosen block at a predefined position
        Instantiate(blockPrefab, transform.position, Quaternion.identity);
    }
}
