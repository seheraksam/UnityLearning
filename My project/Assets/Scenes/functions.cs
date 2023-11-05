using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//monobehavior varsayılan olarak oluşturulan bir sınıftır.
//start ve update metodu içinde gelir
public class functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //üçüncü öncelikli fonksiyon
        Debug.Log("start gelssim");
        //sadece ilk çalışmada çalışır.bir kere çalışır.
    }
    private void OnEnable()
    {
        //İkinci öncelikli
        Debug.Log("onenableden gelssim");

    }
    private void Awake()
    {
        //Önce bütün objelerdeki awakeler çalıştırılır.
        //Hiyerarşide geçiş için 1. fonk bütün folderlarda, 2. fonk bütün folderlarda çalışır.
        //İlk olarak çalışacak metod
        Debug.Log("awakeden geldim hello");
        //sadece ilk çalışmada çalışır.bir kere çalışır.
    }
    // Update is called once per frame
     void Update()
     {
         //her update ile sürekli gelir
         Debug.Log("Her update ile tekrar gelirim");
         //1 saniye
     }
      private void FixedUpdate()
     {
         Debug.Log("Fixedupdate timelarına selam olsun");
         //0.2 sn
     }
     private void LateUpdate()
     {

     }
    private void OnDisable()
    {
        Debug.Log("ondisabledan egldim");
    }
}
