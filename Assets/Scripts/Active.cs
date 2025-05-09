using System.Collections;
using System.Collections.Generic;
using SpatialSys.UnitySDK;
using UnityEngine;

public class Active : SpatialNetworkBehaviour, IVariablesChanged
{
    public void OnVariablesChanged(NetworkObjectVariablesChangedEventArgs args)
    {
        throw new System.NotImplementedException();
    }

    public void Acti()
    {
        GiveControl();
        gameObject.SetActive(true);
    }
    public void Desactive()
    {
        Debug.LogError("Desa");
        GiveControl();
        gameObject.SetActive(false);
    }
    public void GiveControl()
    {
        SpatialNetworkObject obj = GetComponent<SpatialNetworkObject>();
        obj.RequestOwnership();
    }
}
