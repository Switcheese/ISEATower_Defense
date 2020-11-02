using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    //public GameObject firePos;
    //public Rigidbody2D m_rigidbody;
    //// Start is called before the first frame update
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    this.gameObject.SetActive(false);
    //    this.gameObject.transform.position = Vector3.zero;
    //}
    //private void FixedUpdate()
    //{
    //    m_rigidbody.AddForce(this.transform.forward*Time.deltaTime,ForceMode2D.Impulse);
    //    Debug.Log(m_rigidbody.velocity);
    //}
    [Header("가속도")]
    public float thrust;

    [HideInInspector]public Rigidbody2D rb;

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
