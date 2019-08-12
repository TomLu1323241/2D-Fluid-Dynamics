using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] GameObject projectile = null;
    Rigidbody2D myRigidBody;
    // Start is called before the first frame update
    void Start()
    {

        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Shoot();
    }

    void Run()
    {
        float speed = 0;
        if (Input.GetKey(KeyCode.A))
        {
            speed -= this.speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            speed += this.speed;
        }

        Vector2 playerVelocity = new Vector2(speed, myRigidBody.velocity.y);
        myRigidBody.velocity = playerVelocity;
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);

            GameObject temp = GameObject.Instantiate(projectile);
            temp.transform.position = this.transform.position + Vector3.Normalize(objectPos - this.transform.position);
            temp.GetComponent<Rigidbody2D>().velocity = Vector3.Normalize(objectPos - this.transform.position) * 5;
        }
    }
}
