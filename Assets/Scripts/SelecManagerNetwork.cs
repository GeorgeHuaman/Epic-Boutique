using System;
using System.Collections;
using System.Collections.Generic;
using SpatialSys.UnitySDK;
using UnityEngine;

public class SelecManagerNetwork : SpatialNetworkBehaviour, IVariablesChanged
{
    public Manager manager;
    public List<GameObject> dress;
    public List<GameObject> bangles;
    public List<GameObject> necklaces;
    public List<GameObject> hats;
    private NetworkVariable<bool> dresss = new (initialValue: false);
    private NetworkVariable<bool> bangless = new(initialValue: false);
    private NetworkVariable<bool> necklacess = new(initialValue: false);
    private NetworkVariable<bool> hatss = new(initialValue: false);
    private NetworkVariable<int> adress = new(initialValue: 0);
    private NetworkVariable<int> bang = new(initialValue: 0);
    private NetworkVariable<int> neck = new(initialValue: 0);
    private NetworkVariable<int> ha = new(initialValue: 0);
    public void SelectDress(int index)
    {
        GiveControl();
        dresss.value = false;
        //for (int i = 0; i < dress.Count; i++)
        //{
        //    dress[i].SetActive(i == manager.dress);
        //}
        dresss.value = true;
    }
    public void SelectBangles(int index)
    {
        GiveControl();
        bangless.value = false;
        //for (int i = 0; i < bangles.Count; i++)
        //{
        //    bangles[i].SetActive(i == manager.bangles);
        //}
        bangless.value = true;
    }
    public void SelectNecklaces(int index)
    {
        GiveControl();
        necklacess.value = false;
        //for (int i = 0; i < necklaces.Count; i++)
        //{
        //    necklaces[i].SetActive(i == manager.necklaces);
        //}
        necklacess.value = true;
    }
    public void SelectHats(int index)
    {
        GiveControl();
        hatss.value = false;
        //for (int i = 0; i < hats.Count; i++)
        //{
        //    hats[i].SetActive(i == manager.hat);
        //}
        hatss.value = true;
    }

    public void ManagerEntry()
    {
        GiveControl();
        adress.value=manager.dress;
        bang.value = manager.bangles;
        ha.value = manager.hat;
        neck.value = manager.necklaces;
    }
    public void GiveControl()
    {
        SpatialNetworkObject obj = GetComponent<SpatialNetworkObject>();
        obj.RequestOwnership();
    }
    public void OnVariablesChanged(NetworkObjectVariablesChangedEventArgs args)
    {
        if(args.changedVariables.ContainsKey(adress.id))
        {
            Debug.LogError("dresss");
            for (int i = 0; i < dress.Count; i++)
            {
               dress[i].SetActive(i == adress);
            }
            if(hasControl)
              dresss.value = true;
        }
        if (args.changedVariables.ContainsKey(ha.id))
        {
            Debug.LogError("hatss");
            for (int i = 0; i < hats.Count; i++)
            {
              hats[i].SetActive(i == ha);
            }
            if (hasControl)
                hatss.value = true;
        }
        if (args.changedVariables.ContainsKey(neck.id))
        {
            Debug.LogError("necklacess");
            for (int i = 0; i < necklaces.Count; i++)
            {
              necklaces[i].SetActive(i == neck);
            }
            if (hasControl)
                necklacess.value = true;
        }
        if (args.changedVariables.ContainsKey(bang.id))
        {
            Debug.LogError("bangless");
            for (int i = 0; i < bangles.Count; i++)
            {
               bangles[i].SetActive(i == bang);
            }
            if (hasControl)
                bangless.value = true;
        }
    }
}
