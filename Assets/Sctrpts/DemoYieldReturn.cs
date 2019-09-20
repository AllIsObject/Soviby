using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 验证，以下三者相同 ：
/// yield return null;
/// yield return 1000;
/// yield return 0;
/// </summary>
public class DemoYieldReturn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitDemo());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator WaitDemo()
    {
        yield return null;
        int i = 0;
        //while (i<100) {//每帧等待i加到 100
        //    yield return null;
        //    i++;
        //    Debug.Log(i);
        //}
        //while (true)//直接i加到 100
        //{
        //    if (i >= 100)
        //        break;
        //    i++;
        //    Debug.Log(i);
        //}
        yield return Wait();
        yield return WWW.LoadFromCacheOrDownload("",1);
    }
    IEnumerator Wait()
    {
        Debug.Log(Time.time);
        yield return null;
        Debug.Log(Time.time);
    }
    //IEnumerator Wait()
    //{
    //    Debug.Log(Time.time);
    //    yield return 1000;
    //    Debug.Log(Time.time);
    //}
    //IEnumerator Wait()
    //{
    //    Debug.Log(Time.time);
    //    yield return 0;
    //    Debug.Log(Time.time);
    //}
}
