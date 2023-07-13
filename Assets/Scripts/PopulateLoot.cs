using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateLoot : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _loot;
    [SerializeField]
    private Vector3 _offset;

    public void PickLoot()
    {
        int randomElement = Random.Range(0, _loot.Count);
        Instantiate(_loot[randomElement], this.transform.position + _offset, Quaternion.Euler(0, 0, 90));
    }
}
