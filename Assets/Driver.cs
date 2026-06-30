using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.1f;
    [SerializeField] float BoostSpped = 1f;

    [SerializeField] float BumpSpeed = 0.1f;

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float steerCon = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, steerCon, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Boostup")
        {
            moveSpeed = BoostSpped;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = BumpSpeed;
    }
}
