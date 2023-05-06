// Jaycred

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollWithInput : MonoBehaviour
{
    private Rigidbody rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(moveHorz * 10, 0.0f, moveVert * 10);
        rBody.AddForce(moveVector);
    }
}
