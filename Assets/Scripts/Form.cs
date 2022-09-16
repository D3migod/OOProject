using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Form : MonoBehaviour
{
    private Rigidbody formRigidBody;

    protected abstract float rotateSpeed { get; }
    protected abstract float moveSpeed { get; }
    protected abstract float jumpSpeed { get; }

    // Start is called before the first frame update
    void Start()
    {
        formRigidBody = GetComponent<Rigidbody>();
        InvokeRepeating(nameof(Rotate), 1, 4);
        InvokeRepeating(nameof(Move), 2, 4);
        InvokeRepeating(nameof(Jump), 3, 4);
    }

    protected virtual void Rotate()
    {
        transform.Rotate(new Vector3(0, 45, 0) * rotateSpeed);
    }

    protected virtual void Move()
    {
        transform.Translate(Vector3.forward * moveSpeed);
    }

    protected virtual void Jump()
    {
        formRigidBody.AddForce(Vector3.up * 100 * jumpSpeed);
    }
}
