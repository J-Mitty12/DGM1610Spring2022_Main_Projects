using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityEvent : MonoBehaviour
{
    private UnityEvent m_MyEvent;
    // Start is called before the first frame update
    void Start()
    {
        if (m_MyEvent == null) m_MyEvent = new UnityEvent();
        m_MyEvent.AddListener(Ping);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && m_MyEvent != null)
        {
            m_MyEvent.Invoke();
        }
    }

    void Ping()
    {
        Debug.Log("Ping");
    }
}
