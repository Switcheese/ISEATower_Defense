using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControll : MonoBehaviour
{
    public weaponSelect m_WeaponType;
    public SpriteRenderer WeaponImage;
    public int WeaponCounter =0;

    public bulletControll m_BulletControll;

    public void SetWeaponBullet(Sprite _sprite)
    {
        m_BulletControll.bulletObject.BulletSprite.sprite = _sprite;
        m_BulletControll.SetBullets();
    }
}
