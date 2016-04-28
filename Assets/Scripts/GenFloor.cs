using UnityEngine;
using System.Collections;

public class GenFloor : MonoBehaviour 
{
    public Speed floor;

    void createFloor()
    {
        Instantiate(floor, this.transform.position, Quaternion.identity);
    }
    void Start()
    {
        InvokeRepeating("createFloor", 0, floor.transform.localScale.z / Speed.globalSpeed);
    }
}
