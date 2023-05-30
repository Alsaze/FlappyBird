using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    [SerializeField] private GameObject gameManager;
    private GameManager _gameManager;
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _gameManager = gameManager.GetComponent<GameManager>();
    }

    private void PlayerController()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            float jumpForce = 200f;
            _rigidbody2D.velocity = new Vector2(1.5f, 0);
            _rigidbody2D.AddForce(Vector2.up * jumpForce);
        }
    }

    private void Update()
    {
        PlayerController();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "PipePrefab(Clone)")
        {

            _gameManager.Score();
        }

        if ((other.gameObject.name == "PipeTop") || (other.gameObject.name == "PipeDown"))
        {
            
            _gameManager.Lose();
        }
    }
}