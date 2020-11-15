using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float SpawnTime;
    public Transform TargetPos;
    public SpriteRenderer EnemyImage;
    public float moveTime;
    bool isMove;

    void Awake()
    {
        isMove = false;
        StartCoroutine(SpawnInit());
    }

    void Update()
    {
        if (isMove)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, TargetPos.position, moveTime * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        other.CompareTag("bullet");
        
    }
    IEnumerator SpawnInit()
    {
        yield return new WaitForSeconds(SpawnTime);
        EnemyImage.enabled = true;
        isMove = true;
    }
}
