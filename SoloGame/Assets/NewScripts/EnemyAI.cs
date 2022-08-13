using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {


    public Transform player;
    public string sceneName;

    private int speed = 2;
    private int maxDist;
    private int minDist;
    private int killDistance;
    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        maxDist = 10;
        minDist = 5;
        killDistance = 1;
}

    // Update is called once per frame
    void Update() {
        transform.LookAt(player);
        if (Vector3.Distance(transform.position, player.position) >= minDist){
            transform.position += transform.forward * speed * Time.deltaTime;
            anim.SetInteger("Speed",speed);

            if (Vector3.Distance(transform.position, player.position) <= maxDist) { 
                anim.SetTrigger("Attack");
            }if(Vector3.Distance(transform.position, player.position) <= killDistance) { 
                Application.LoadLevel(sceneName);
            }
        }
    }
}
