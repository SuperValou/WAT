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
        GameObject g = Instantiate(quad, new Vector3(point.x, point.y, this.transform.position.z), Quaternion.identity) as GameObject;

        //g.transform.Rotate(g.transform.forward, Random.value * Random.Range(0, 180));
        
    }

    void Start()
    {
        InvokeRepeating("createQuad", 0, 1F / quadPerSecond);
    }
}
