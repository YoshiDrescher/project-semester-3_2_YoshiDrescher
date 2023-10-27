using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeaponInventoryEntry : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayNameText;
    [SerializeField] private GameObject selectionVisiuals;

    public Weapon weapon;
    
    public void Initialize(Weapon weapon)
    {
        selectionVisiuals.SetActive(false);
        this.weapon = weapon;
        displayNameText.text = weapon.displayName;
    }

    public void SetSelect(bool isSelected)
    {
        selectionVisiuals.SetActive(isSelected);
    }
}
