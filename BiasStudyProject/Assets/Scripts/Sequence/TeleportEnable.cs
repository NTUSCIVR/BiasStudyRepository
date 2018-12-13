using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class TeleportEnable : VRTK_DestinationPoint {

    [SerializeField]
    GameObjectRuntimeSet m_set;

    bool disable = false;

	// Update is called once per frame
	void Update () {
        base.Update();
        if (disable)
            return;
        if (m_set.m_list.Count == 0)
        {
            disable = false;
            enableTeleport = true;
        }
	}
}
