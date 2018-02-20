using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInfo
{
    ObjInfo()
    {
        base_info = 0;
        base_pos=0;
    }
    public int base_info;//オブジェクトの状態　0なし　1～6サイコロ　7プレイヤ
    public int base_pos;//配列で表現
                      //public int blast_rady;//消滅猶予
    void cleanup()
    {
        if (base_info == 0)
        {

        }
    }
}
public class Test
{
    public int xi_info;//オブジェクトの状態　0なし　1～6サイコロ　7プレイヤ
    public int xi_pos;//配列で表現
                      //public int blast_rady;//消滅猶予
    void cleanup()
    {
        if (xi_info == 0)
        {

        }
    }
}
public class xiBase : MonoBehaviour {

     bool[] pos=new bool[36];
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


    //  public Xi_player xi_player;
    public Test test;
    public GameObject ref_obj;
    public Xi_player xi_pl;
    ObjInfo[] objInfo = new ObjInfo[36];
    void Start () {
        test = new Test();

   
         
        ref_obj = GameObject.Find("Player");
        xi_pl = ref_obj.GetComponent<Xi_player>();
        objInfo[1].base_info = xi_pl.obj_status;
        objInfo[1].base_pos = xi_pl.pos;
        test.xi_info= xi_pl.obj_status;
        test.xi_pos = xi_pl.pos;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {

            //for(int i = 0; i < 36; i++)
            //{
            //      if (pos[i] == false)
            //      {
            //          Debug.Log("null");
            //      }
            //}
            //Debug.Log((-player.transform.position.z/6)+player.transform.position.x);
            Debug.Log(objInfo[1].base_info);
            Debug.Log(objInfo[1].base_pos);
            //Debug.Log(/*test.xi_info*/xi_pl.obj_status);
            //Debug.Log(/*test.xi_pos */xi_pl.pos);

        }

    }
}
