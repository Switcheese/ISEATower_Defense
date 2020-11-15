using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject BulletObject;

    [Header("가속도")]
    public float thrust;

    public SpriteRenderer BulletSprite;

    [HideInInspector]
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        this.gameObject.SetActive(false);
    }
    void FixedUpdate()
    {
        //rb.velocity = new Vector2(5,5);
        transform.position += transform.right * thrust;
    }
    void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }
}
