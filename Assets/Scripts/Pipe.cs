using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;

    [SerializeField] private GameObject pipeSpawner;
    private PipeSpawner _pipeSpawner;

    private bool _isSpawn;

    private void Start()
    {
        _pipeSpawner = pipeSpawner.GetComponent<PipeSpawner>();
    }

    private void Update()
    {
        PipeMovment();
    }

    private void PipeMovment()
    {
        transform.Translate(-1 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "PipeDestroyer")
        {

            Destroy(pipePrefab);
            _isSpawn = false;
        }

        if (other.name == "PipeSpawner")
        {
            
            if (_isSpawn == false)
            {
                
                _pipeSpawner.SpawnPipe();
                _isSpawn = true;
            }
        }
    }
}