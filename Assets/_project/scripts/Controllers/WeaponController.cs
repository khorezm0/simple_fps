using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public Transform WeaponsRoot;
    public GameObject[] Weapons;

    private GameObject[] _weaponInstances;
    private int _currentWeaponIndex = 0;

    private void Start()
    {
        _weaponInstances = new GameObject[0];
    }

    public void SwitchToNextWeapon()
    {
        var val = _currentWeaponIndex + 1;
        if (val >= _weaponInstances.Length) val = 0;

        SetWeapon(val);
    }

    public void SwitchToPrevWeapon()
    {
        var val = _currentWeaponIndex - 1;
        if (val < _weaponInstances.Length) val = _weaponInstances.Length;

        SetWeapon(val);
    }

    public void SetWeapon(int index)
    {
        if (_weaponInstances.Length <= index || _weaponInstances.Length == 0) return;
        _currentWeaponIndex = index;

        //change renderer and so on
    }
}