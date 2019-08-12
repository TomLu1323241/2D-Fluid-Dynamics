using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField] GameObject particle = null;

    // Start is called before the first frame update
    void Start()
    {
        float time = Time.time;
        float length = particle.GetComponent<SpriteRenderer>().sprite.bounds.size.x * particle.transform.localScale.x;
        for (int i = 0; i < 18 / length; i++)
        {
            for (int j = 0; j < 5 / length; j++)
            {
                GameObject.Instantiate(particle).transform.position = new Vector3(-9f + length / 2 + length * i, -5f + length / 2 + length * j);
            }
        }
        Debug.Log(Time.time - time);
        Debug.Log((18 / length) * (5 / length));
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        //    Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);

        //    Collider2D[] cols = Physics2D.OverlapCircleAll(objectPos, 1);
        //    for (int i = 0; i < cols.Length; i++)
        //    {
        //        if (cols[i].gameObject.GetComponent<Rigidbody2D>() != null)
        //        {
        //            cols[i].gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        //            cols[i].gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.Normalize(cols[i].transform.position - objectPos) * 10;
        //        }
        //    }
        //}
    }
}
