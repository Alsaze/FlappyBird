using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;

    private void Start()
    {
        SpawnPipe();
    }

    public void SpawnPipe()
    {
        var position = new Vector3(pipePrefab.transform.position.x, Random.Range(-2.5f, 2.5f), 0);
        Instantiate(pipePrefab, position, Quaternion.identity);
    }
}