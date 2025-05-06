using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    public List<GameObject> dress;
    public List<GameObject> bangles;
    public List<GameObject> necklaces;
    public List<GameObject> hats;
    public void SelectDress(int index)
    {
        for (int i = 0; i < dress.Count; i++)
        {
            dress[i].SetActive(i == index);
        }
    }
    public void SelectBangles(int index)
    {
        for (int i = 0; i < bangles.Count; i++)
        {
            dress[i].SetActive(i == index);
        }
    }
    public void SelectNecklaces(int index)
    {
        for (int i = 0; i < necklaces.Count; i++)
        {
            dress[i].SetActive(i == index);
        }
    }
    public void SelectHats(int index)
    {
        for (int i = 0; i < hats.Count; i++)
        {
            dress[i].SetActive(i == index);
        }
    }
}
