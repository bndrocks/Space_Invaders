﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    public Vector2 Velocidade;
    void Start()
    {
       Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
       rigidbody.AddForce(Velocidade);

    }

}
