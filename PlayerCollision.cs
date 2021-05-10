using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public SphereCollider slippery;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
           movement.enabled = false;
           FindObjectOfType<GameManager>().EndGame();
        }
    }
}
