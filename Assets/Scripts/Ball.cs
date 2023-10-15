using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 100.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
        AddStartingForce();
    }

    public void AddStartingForce()
    {
        float x = 1.0f;
        float y = 0.78f;

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);


    }

    public void increaseSpeed(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }


}
