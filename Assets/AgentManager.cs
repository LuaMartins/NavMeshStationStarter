using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;

    // Start is called before the first frame update
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai"); // função criada para atribuir na unity
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // condição para orientação do click do mouse
        {
            RaycastHit hit; // controle do ambiente para navegação

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) // marca e posiciona para disparar o hit para trafego
            {
                foreach (GameObject a in agents) // para repetir a transição
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}