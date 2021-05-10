using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private float SmoothSpeed = 0.15f; 
    void FixedUpdate()
    {
        Vector3 Possition = player.position + offset;
        Vector3 SmoothVector = Vector3.Lerp(transform.position, Possition, SmoothSpeed);

        transform.position = SmoothVector;

        transform.LookAt(player);
    }
}
