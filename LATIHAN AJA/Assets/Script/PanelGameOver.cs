using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PanelGameOver : MonoBehaviour
{
    [SerializeField] private GameObject panelGameOver;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (panelGameOver.activeInHierarchy)
            {
                panelGameOver.SetActive(false);
            }
            else
            {
                panelGameOver.SetActive(true);
            }
        }
    }
}
