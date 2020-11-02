using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class EnemySpawner : MonoBehaviour
{
    public float XspawnRange;
    public float YspawnRange;

    public Vector3 toPosition;

    public GameObject spawnObject;
    List<GameObject> Monsterlist;

    void OnDrawGizmos()
    {
        Vector3 f_fromPos = new Vector3(XspawnRange, YspawnRange);
        Gizmos.color = Color.red;
        Gizmos.DrawRay(this.transform.position, toPosition);
    }
    private void Awake()
    {
        Monsterlist = new List<GameObject>();
    }

    private void Start()
    {
        int f_range = Random.Range(0, 300);
        Monsterlist.Add(Instantiate<GameObject>(spawnObject, this.transform));
        Monsterlist[0].transform.localPosition = new Vector3(f_range, 0, 0);
    }
}
