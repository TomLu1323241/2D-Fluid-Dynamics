using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D[] cols = Physics2D.OverlapCircleAll(this.transform.position, 1);
        for (int i = 0; i < cols.Length; i++)
        {
            if (cols[i].gameObject.GetComponent<Rigidbody2D>() != null)
            {
                cols[i].gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                cols[i].gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.Normalize(cols[i].transform.position - this.transform.position - Vector3.down) * 10;
            }
        }
        GameObject.Destroy(this.gameObject);
    }
}
