using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1.0f;
    public float sidewaysForce = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // To mess with physics we use FixedUpdate() instead of Update()
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -3f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
