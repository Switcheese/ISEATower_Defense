using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletControll : MonoBehaviour
{
    [Header("공격 주기")]
    public float waitforsecond_Time;
    [Space()]

    public bullet bulletObject;
    public GameObject bulletObj;

    public GameObject firePos;
    public int bulletCount;
    public int usingbulletCount;
    List<GameObject> bulletSit;

    // Start is called before the first frame update
    public void SetBullets()
    {
        usingbulletCount = 0;
        bulletSit = new List<GameObject>();
        for (usingbulletCount = 0; usingbulletCount < bulletCount; usingbulletCount++)
        {
            if (usingbulletCount == bulletCount)
            {
                usingbulletCount = 0;
            }
            else
            {
                GameObject f_bullet = Instantiate<GameObject>(bulletObject.BulletObject, this.transform);
                f_bullet.SetActive(false);

                bulletSit.Add(f_bullet);
            }
        }

        //StartCoroutine(fire());
    }

    public void Fire()
    {
        for (int i = 0; i < bulletSit.Count; i++)
        {
            if (bulletSit[i].activeSelf == false)
            {
                bulletSit[i].transform.position = firePos.transform.position;
                bulletSit[i].SetActive(true);
                bulletSit[i].transform.right = firePos.transform.right;
                break;
            }
        }
    }
    public IEnumerator fire()
    {
        yield return new WaitForSeconds(1.5f);

        while (true)
        {
            for (int i = 0; i < bulletSit.Count; i++)
            {
                if (bulletSit[i].activeSelf == false)
                {
                    bulletSit[i].transform.position = firePos.transform.position;
                    bulletSit[i].SetActive(true);
                    bulletSit[i].transform.right = firePos.transform.right;
                    break;
                }

            }
            yield return new WaitForSeconds(waitforsecond_Time);
        }
    }
}
