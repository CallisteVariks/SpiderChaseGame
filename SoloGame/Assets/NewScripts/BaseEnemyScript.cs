using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyScript : MonoBehaviour {

    private Animator anim;
    private GameObject enemy;

        
        // Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        enemy = GameObject.FindWithTag("Player");
        anim = enemy.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
