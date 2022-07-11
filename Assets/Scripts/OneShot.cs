using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShot : Buffs
{
    void Start()
    {
        cdValue = 10f;
	buffValue = 3f;
    }

    protected override void Buffer()
    {
	GameObject.Find("Logic").GetComponent<SpawnScript>().SetDamage(999);
    }

    protected override void UnBuffer()
    {
	GameObject.Find("Logic").GetComponent<SpawnScript>().SetDamage(1);
    }
}
