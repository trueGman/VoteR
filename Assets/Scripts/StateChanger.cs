using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChanger : MonoBehaviour
{
    public Animator MC, MC_Global, NPC, NPC_Global, deskDude;

    public int state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MC.SetInteger("State", state);
        MC_Global.SetInteger("State", state);
        NPC.SetInteger("State", state);
        NPC_Global.SetInteger("State", state);
    }
}
