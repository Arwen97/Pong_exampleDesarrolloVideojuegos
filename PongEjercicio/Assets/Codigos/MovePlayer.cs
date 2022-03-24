using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] public Camera m_mainCamara;
    [SerializeField] public GameObject m_cubo1, m_cubo2, m_cubo3, m_cubo4;
    [SerializeField] public float m_distanceCamara;


    void OnDrawGizmos()
    {

        Vector3 cubo1up = new Vector3(Screen.width, Screen.height, m_distanceCamara);
        Vector3 Distance1 = m_mainCamara.ScreenToWorldPoint(cubo1up);
        //m_cubo1.transform.position = Distance1;
        Gizmos.DrawWireSphere(Distance1, 2);

        Vector3 Cubo2up = new Vector3(0, Screen.height, m_distanceCamara);
        Vector3 Distance2 = m_mainCamara.ScreenToWorldPoint(Cubo2up);
       // m_cubo2.transform.position = Distance2;
        Gizmos.DrawWireSphere(Distance2, 2);

        Vector3 cubo3up = new Vector3(0, 0, m_distanceCamara);
        Vector3 Distance3 = m_mainCamara.ScreenToWorldPoint(cubo3up);
       // m_cubo3.transform.position = Distance3;
        Gizmos.DrawWireSphere(Distance3, 2);

        Vector3 Cubo4up = new Vector3(Screen.width, 0, m_distanceCamara);
        Vector3 Distance4 = m_mainCamara.ScreenToWorldPoint(Cubo4up);
       // m_cubo4.transform.position = Distance4;
        Gizmos.DrawWireSphere(Distance4, 2);

    }





}
