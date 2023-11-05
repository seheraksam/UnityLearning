using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class publicFunctions : MonoBehaviour
{
    //public,private
    public string ad;
    private int yas;
    private IEnumerator cont;
    private IEnumerator cont2;

    // Start is called before the first frame update
    void Start()
    {
        cont = Denemem(3);
        cont2 = Denemem(2);
        StartCoroutine(cont); 
    }

    IEnumerator Denemem(float sn)
    {

        while (true)
        {
            //kodlar burada ve bekleme zamanı olmalı
            yield return new WaitForSeconds(sn);
            Debug.Log("2. yazdırma");
        }
        
    }
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StopCoroutine(cont);
        }
        if (Input.GetKeyDown("z"))
        {
            StopCoroutine(cont2);
        }
    }


}
