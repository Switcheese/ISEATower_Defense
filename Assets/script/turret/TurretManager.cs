using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public class TurretManager : MonoBehaviour
{
    static public TurretManager instance = null;
    public Sprite ChangeForm;

    private void Awake()
    {
        instance = this.gameObject.GetComponent<TurretManager>();
    }
}
