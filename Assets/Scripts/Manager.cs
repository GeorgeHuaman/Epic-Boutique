using System.Collections;
using System.Collections.Generic;
using SpatialSys.UnitySDK;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public SelectManager[] selectManager;
    public int dress ;
    public int bangles;
    public int necklaces;


    public void SelectDress(int index)
    {
        for (int i = 0; i < selectManager.Length; i++)
        {
            selectManager[i].SelectDress(index);
        }
        dress = index;
    }
    public void SelectBangles(int index)
    {
        for (int i = 0; i < selectManager.Length; i++)
        {
            selectManager[i].SelectBangles(index);
        }
        bangles = index;
    }
    public void SelectNecklaces(int index)
    {
        for (int i = 0; i < selectManager.Length; i++)
        {
            selectManager[i].SelectNecklaces(index);
        }
        necklaces= index;
    }

}
