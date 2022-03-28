using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Hitted " + other.transform.name);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered " + other.transform.name);
    }
}
