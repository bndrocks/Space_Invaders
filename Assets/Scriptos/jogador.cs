using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour
{
    public float Velocidade;
    private float constante = 0.7F;
    public float HorizontalAxis;
    public Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        HorizontalAxis = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(constante * Velocidade * HorizontalAxis, 0);
    }
}
