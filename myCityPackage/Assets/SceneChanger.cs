using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 2초 후에 ChangeScene 함수를 호출합니다.
        Invoke("ChangeScene", 2f);
    }

    void ChangeScene()
    {
        // "testscene" 씬으로 변경합니다.
        SceneManager.LoadScene("testscene");
    }
}
