using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    Animator m_Animator;
    bool mpu;
    bool mpr;
   
    public GameObject combat;
    public GameObject i1;
    public GameObject i2;
    public GameObject i3;
    public GameObject i4;
    private int m;
    // Start is called before the first frame update
    void Start()
    {
        i1.SetActive(true);
        i2.SetActive(false);
        i3.SetActive(false);
        i4.SetActive(false);
       
 m_Animator = gameObject.GetComponent<Animator>();
        mpu = false;
        mpr = false;
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown("1"))
        {
            i1.SetActive(true);
            i2.SetActive(false);
            i3.SetActive(false);    
            i4.SetActive(false);
            m = 1;
        }
            if (Input.GetKeyDown("2"))
            {
                i1.SetActive(false);
                i2.SetActive(true);
                i3.SetActive(false);
                i4.SetActive(false);
            m = 2;

        }
            if (Input.GetKeyDown("3"))
            {
                i1.SetActive(false);
                i2.SetActive(false);
                i3.SetActive(true);
                i4.SetActive(false);
            m = 3;
        }
            if (Input.GetKeyDown("4"))
            {
                i1.SetActive(false);
                i2.SetActive(false);
                i3.SetActive(false);
                i4.SetActive(true);
            m = 4;
        }

        if (m == 1)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                Debug.Log("m1");
                mpu = true;
            }
        }
        if (m == 2)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                Debug.Log("m2");
                mpr = true;
            }
        }
        if (m == 3)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                Debug.Log("m3");
            }
        }
        if (m == 4)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                Debug.Log("m4");
                
            }
        }


    }
    }
