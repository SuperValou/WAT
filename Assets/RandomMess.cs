using UnityEngine;
using System.Collections;

public class RandomMess : MonoBehaviour 
{
    public float radius = 10;
    public float power = 10;
    public int freq = 10;

	void FixedUpdate()
    {
        int alea = Random.Range(1, freq);
        if (alea == 1)
        {
            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
            foreach (Collider hit in colliders)
            { 
                if (hit.gameObject.tag == "quad")
                {
                    continue;
                }
                Rigidbody rb = hit.GetComponent<Rigidbody>();

                if (rb != null)
                    rb.AddExplosionForce(power, explosionPos, radius);

            }
        }
    }
}
