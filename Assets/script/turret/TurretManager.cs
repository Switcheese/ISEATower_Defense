using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public enum weaponSelect
{
    Defalut =-1,
    Nomal=0,
    Extended,
    Cannon,
    Laser,
}

public class TurretManager : MonoBehaviour
{
    static public TurretManager instance = null;
    public Sprite[] ChangeForm;
    public Sprite[] ChangeBullet;
    public TurretControll[] Guns;

    private void Awake()
    {
        instance = this.gameObject.GetComponent<TurretManager>();
    }

    public void WeaponChange2Click(int _index)
    {
        if (ChangeForm.Length == Guns[_index].WeaponCounter)
        {
            Guns[_index].WeaponCounter = 0;
            Guns[_index].m_WeaponType = (weaponSelect)Guns[_index].WeaponCounter;
            Guns[_index].WeaponImage.sprite = ChangeForm[Guns[_index].WeaponCounter++];
        }
        else
        {
            Guns[_index].m_WeaponType = (weaponSelect)Guns[_index].WeaponCounter;
            Guns[_index].WeaponImage.sprite = ChangeForm[Guns[_index].WeaponCounter++];
        }
        Guns[_index].SetWeaponBullet(ChangeBullet[Guns[_index].WeaponCounter]);
    }
}
