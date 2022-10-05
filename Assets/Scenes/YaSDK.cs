using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YaSDK : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Запуск...");
        Bridge.Initialize(isInitialized =>
        {
            if (isInitialized)
            {
                Debug.Log(Bridge.platform.id);
                Debug.Log("Этап 2.");
            }
            else
            {
                Debug.Log("Ошибка.");
            }
        });
    }
}

