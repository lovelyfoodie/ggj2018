//------------------------------------------------------------------------------
// Copyright © 2018 alchemedium LLC. All Rights Reserved.
// Author: Ryan Brolley
//------------------------------------------------------------------------------

using UnityEngine;

public class Cell : MonoBehaviour
{
    public float startingTorque = 1f;
    public float maxSpeed = 1f;

    private Rigidbody2D _rb;
    private float _sqrMagMaxSpeed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddTorque(Random.Range(0, startingTorque));

        _sqrMagMaxSpeed = maxSpeed * maxSpeed;
    }

    private void OnValidate()
    {
        _sqrMagMaxSpeed = maxSpeed * maxSpeed;
    }

    private void FixedUpdate()
    {
        if (_rb.velocity.sqrMagnitude > _sqrMagMaxSpeed)
        {
            var exceed = _rb.velocity.sqrMagnitude - _sqrMagMaxSpeed;
            _rb.AddForce(_rb.velocity.normalized * -1f * Mathf.Sqrt(exceed));
        }
    }

    public void AddForce(Vector3 force)
    {
        _rb.AddForce(force);
    }
}
