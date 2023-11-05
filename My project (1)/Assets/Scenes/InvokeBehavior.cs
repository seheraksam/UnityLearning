using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("write", 3f);
        InvokeRepeating("write", 2f, .8f);
    }
    void write()
    {
        if (IsInvoking("yaziyaz"))
            Debug.Log("evet");
        else
            Debug.Log("hayır");



        if (Input.GetKeyDown("space"))
        {
            CancelInvoke();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            // StopCoroutine(birincicont);
            CancelInvoke(); // bütün hepsini durdurur
        }
    }
}
