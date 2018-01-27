//------------------------------------------------------------------------------
// Copyright © 2018 alchemedium LLC. All Rights Reserved.
// Author: Ryan Brolley
//------------------------------------------------------------------------------

using UnityEngine;

public class Cell : MonoBehaviour
{
    public float startingTorque = 1f;
    private Rigidbody2D _rb;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddTorque(Random.Range(0, startingTorque));
    }

    public void AddForce(Vector3 force)
    {
        _rb.AddForce(force);
    }
}
