// Jaycred

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowAndShrink : MonoBehaviour
{
    private GameObject snowball;
    private Rigidbody rBody;

    private float maxScale = 10.0f;
    private float minScale = 0.3f;

    void Start()
    {
        snowball = this.gameObject;
        rBody = GetComponent<Rigidbody>();
    }

    void OnCollisionStay(Collision col)
    {
        float vel = rBody.velocity.magnitude;
        if (vel != 0)
        {
            Vector3 snowballScale = snowball.transform.localScale;

            //Grow will be slower than shrink
            Vector3 growVector = new Vector3(vel/500, vel/500, vel/500);
            Vector3 shrinkVector = new Vector3(vel/100, vel/100, vel/100);

            if (col.gameObject.tag == "Snow" && snowballScale.x < maxScale && snowballScale.y < maxScale
                && snowballScale.z < maxScale)
            {
                snowball.transform.localScale += growVector;
            }
            else if (col.gameObject.tag == "Gravel" && snowballScale.x > minScale && snowballScale.y > minScale
                && snowballScale.z > minScale)
            {
                snowball.transform.localScale -= shrinkVector;
            }
        }
    }

}
