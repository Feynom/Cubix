using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float force = 1500f;
    public float sidewaysForce = 700f;

    public Rigidbody rb;

    private
    void FixedUpdate()
    {
        rb.AddForce(0, 0, (float)force * Time.deltaTime);

        if (rb.position.y < 0)
            FindObjectOfType<GameManager>().EndGame();


        Vector3 acceleration = Input.acceleration;

        rb.AddForce(sidewaysForce * acceleration.x * Time.deltaTime, 0, 0, ForceMode.Acceleration);
    }
}