using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

    public bool moveflag=false;
    public float speed ;

    public float testmove=0;

    public float angle = 0;

    public int pos = 0;

    public float x_pos = 0;
    public float z_pos = 0;
    public int x_vec = 0;
    public int z_vec = 0;
    public bool DDD;

    public GameObject chara;
	// Use this for initialization
	void Start () {
         StartCoroutine(MoveControl());

    }
   
    // Update is called once per frame
    IEnumerator MoveControl()
    {
        while (true)
        {
            if (moveflag == false)
            {
                if (Input.GetKey("up"))
                {
                    if (this.transform.position.z <0 )
                    {
                        while (true)
                        {


                            transform.position += transform.forward / speed;
                            testmove += 1 / speed;
                            if (testmove >= 1)
                            {
                                testmove = 0;
                                break;
                            }
                            z_vec = 1;
                            yield return null;

                        }
                        pos -= 6; 
                    }
                }
                if (Input.GetKey("down"))
                {
                    if (this.transform.position.z > -4.9)
                    {
                        while (true)
                        {
                            transform.position -= transform.forward / speed;
                            testmove += 1 / speed;
                            if (testmove >= 1)
                            {
                                testmove = 0;
                                break;
                            }
                            z_vec = -1;
                            yield return null;
                        }
                    pos += 6;
                    }
                }
                    
                if (Input.GetKey("right"))
                {
                    if (this.transform.position.x < 4.9)
                    {
                        while (true)
                        {
                            transform.position += transform.right / speed;
                            testmove += 1 / speed;
                            if (testmove >= 1)
                            {
                                testmove = 0;
                                break;
                            }
                            x_vec = 1;
                            yield return null;

                        }
                    pos += 1;
                    }
                }
                if (Input.GetKey("left"))
                {
                    if (this.transform.position.x >0.1)
                    {
                        while (true)
                        {
                            transform.position -= transform.right / speed;
                            testmove += 1 / speed;
                            if (testmove >= 1)
                            {
                                testmove = 0;
                                break;
                            }
                            x_vec = -1;
                            yield return null;

                        }
                    pos -= 1;
                    }
                }
                DDD = false;
                x_vec = 0;
                z_vec = 0;
            }
            

                if (Input.anyKey)
            {

                moveflag = true;
            }
            else
            {
               // transform.position.x = x_pos;
                moveflag = false;
            }
            //OnCollisionEnter();
            // Debug.Log("毎フレームの処理");

            
            yield return null;
        }
    }



    void Update ()
    {
       


    }
   
}
//z
//for (int i = 0; i < forcount; i++)
//{

//    transform.position += transform.forward / speed;
//    Debug.Log("up");
//    Debug.Log(this.transform.eulerAngles.y);
//    if (this.transform.eulerAngles.y != 0)
//    {
//        if (this.transform.eulerAngles.y >= 180)
//        {
//            //while ()
//        }
//        if (this.transform.eulerAngles.y < 180)
//        {

//        }
//    }
//    yield return null;
//}
/*for (int i = 0; i < forcount; i++)
{
    transform.position -= transform.right / speed  ;
    Debug.Log("left");
    yield return null;
}*/
