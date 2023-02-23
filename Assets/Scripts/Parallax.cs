using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float m_Length, m_StartPos;
    public GameObject m_Cam;
    public float m_ParallaxEffect;

  
    void Start()
    {
        m_StartPos = transform.position.x;
        m_Length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float temp = (m_Cam.transform.position.x * (1 - m_ParallaxEffect));
        float dist = (m_Cam.transform.position.x * m_ParallaxEffect);

        transform.position = new Vector3(m_StartPos + dist, transform.position.y, transform.position.z);

        if (temp > m_StartPos + m_Length) m_StartPos += m_Length;
        else if (temp < m_StartPos - m_Length) m_StartPos -= m_Length;
    }
}
