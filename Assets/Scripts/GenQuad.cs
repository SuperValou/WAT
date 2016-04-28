using UnityEngine;
using System.Collections;

public class GenQuad : MonoBehaviour 
{
    public float radius = 10;
    public float quadPerSecond = 10;
    public GameObject quad;

    void createQuad()
    {
        var point = Random.insideUnitCircle * radius;
        Instantiate(quad, new Vector3(point.x, point.y, this.transform.position.z), Quaternion.identity);

        
    }

    void Start()
    {
        InvokeRepeating("createQuad", 0, 1F / quadPerSecond);
    }
}
