using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{

    Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Mathf.Abs(body.velocity.magnitude) < 0.1 && Physics2D.Raycast(this.transform.position, Vector2.down / 2).collider != null)
        //{
        //    body.bodyType = RigidbodyType2D.Static;
        //}
    }
}
