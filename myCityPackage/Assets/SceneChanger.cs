using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 2�� �Ŀ� ChangeScene �Լ��� ȣ���մϴ�.
        Invoke("ChangeScene", 2f);
    }

    void ChangeScene()
    {
        // "testscene" ������ �����մϴ�.
        SceneManager.LoadScene("testscene");
    }
}
