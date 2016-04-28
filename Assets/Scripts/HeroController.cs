using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class HeroController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Boundary boundary;

    private Rigidbody rgBd;

    void Start()
    {
        this.rgBd = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = - Input.GetAxis("Horizontal");

        rgBd.velocity = new Vector3(moveHorizontal * speed, rgBd.velocity.y, 0.0f);
        
        rgBd.position = new Vector3
        (
            Mathf.Clamp(rgBd.position.x, boundary.xMin, boundary.xMax),            
            Mathf.Clamp(rgBd.position.y, boundary.yMin, boundary.yMax),
            0.0f
        );

    }

    bool canJump = true;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "death")
        {
            Application.LoadLevel(0);
        }
        else
        {
            canJump = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            canJump = false;
            this.rgBd.AddForce(new Vector3(0,jumpForce,0), ForceMode.Impulse);
        }
    }
}