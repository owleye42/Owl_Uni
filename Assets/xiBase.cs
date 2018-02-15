using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xiBase : MonoBehaviour {

     int[]pos=new int[36];
    //
    // 0  1  2  3  4   5
    // 6  7  8  9  10  11
    // 12 13 14 15 16  17
    // 18 19 20 21 22  23
    // 24 25 26 27 28  29
    // 30 31 32 33 34  35
    //
    //zposは６倍
    //xは等倍
    //z*6+xで現在の配列の場所
    //
    //
    //0=-2.5,1,2.5
    //5=2.5,1,2.5
    //35=2.5,1,-2.5
    //30=-2.5,1,-2.5
    //上-6　停止条件n<=5
    //右+1　停止条件(n+1)%6==0
    //左-1　停止条件n%6==0
    //下+6　停止条件n>=30
    //0 1 2 3 4  5
    //0 1 2 3 4  5
    //0 1 2 3 4  5
    //0 1 2 3 4  5
    //0 1 2 3 4  5
    //0 1 2 3 4  5
    // Use this for initialization
    GameObject player;
    public controller controller;

   
    void Start () {
        player = GameObject.Find("Player");
        
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
         
            //Debug.Log((-player.transform.position.z/6)+player.transform.position.x);
            Debug.Log(player.GetComponent<controller>().pos);
           
        }

    }
}
