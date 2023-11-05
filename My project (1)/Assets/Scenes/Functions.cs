using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class publicmethodlar : MonoBehaviour
{

    //  public
    //  private

    public string ad;
    private int yas;

    private IEnumerator birincicont;
    private IEnumerator birincicont2;



    void Start()
    {

        //birincicont = Denemem(2);
        birincicont2 = Denemem2(3);

        // StartCoroutine(birincicont);
        StartCoroutine(birincicont2);

    }

    IEnumerator Denemem(float saniyem)
    {

        while (true)
        {
            Debug.Log("2 saniye bekledim");
            //Debug.Log("1.yazdırma");
            // yield return null; // bir frame bekler- kare bekler- update gibi
            yield return new WaitForSeconds(saniyem);
            // Debug.Log("2 saniye bekledim");

        }


    }

    IEnumerator BensonradanOldum()
    {
        Debug.Log("Ben sonradan oldum");
        yield return null;
    }
    IEnumerator Denemem2(float saniyem)
    {

        while (true)
        {
            Debug.Log("2. ELEMAN");
            //Debug.Log("1.yazdırma");
            // yield return null; // bir frame bekler- kare bekler- update gibi
            yield return new WaitForSeconds(saniyem);  // bizim saniyemize göre
            yield return StartCoroutine(BensonradanOldum());
            // yield return new WaitForFixedUpdate();
            // Debug.Log("2 saniye bekledim");

        }


    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            // StopCoroutine(birincicont);
            StopAllCoroutines(); // bütün hepsini durdurur
        }
    }


}
