using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 200f;
    [SerializeField] private float moveSpeed = 10f;

    private void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        if (moveAmount == 0)
        {
            return;
        }
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
