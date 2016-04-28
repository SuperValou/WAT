using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour 
{
    public float speed = 50;

    public static float globalSpeed = 50;

    private Rigidbody rgbd;


    void Awake()
    {
        globalSpeed = speed;
    }

	void Start () 
    {
        rgbd = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () 
    {
        this.rgbd.velocity = Vector3.forward * globalSpeed;	
	}
}
