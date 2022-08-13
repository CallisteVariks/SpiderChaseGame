using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int maxHP=200;
    public int currentHP;
    private Animator anim;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        currentHP = maxHP;
    }
	
    void TakeDamage(int amount)    {
        currentHP -= amount;
        if (currentHP <= 0)
            anim.SetTrigger("Death");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
