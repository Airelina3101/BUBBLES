using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPlay : MonoBehaviour
{
    public GameObject ButtonMenu;
    public GameObject ButtonOnFree;
    public GameObject ButtonOnTime;
    public GameObject ButtonAutors;
    public GameObject LoadSceneFree;
    public GameObject LoadSceneTime;
    public GameObject EndGame;

    public void FreePlay()
    {
        ButtonMenu.SetActive(!ButtonMenu.activeSelf);
        ButtonOnFree.SetActive(!ButtonOnFree.activeSelf);
    }
    public void OnTime()
    {
        ButtonMenu.SetActive(!ButtonMenu.activeSelf);
        ButtonOnTime.SetActive(!ButtonOnTime.activeSelf);
    }
    public void OnAutors()
    {
        ButtonMenu.SetActive(!ButtonMenu.activeSelf);
        ButtonAutors.SetActive(!ButtonAutors.activeSelf);
    }
    public void CancelOnFree()
    {
        ButtonMenu.SetActive(!ButtonMenu.activeSelf);
        ButtonOnFree.SetActive(!ButtonOnFree.activeSelf);
    }
    public void CancelOnTime()
    {
        ButtonMenu.SetActive(!ButtonMenu.activeSelf);
        ButtonOnTime.SetActive(!ButtonOnTime.activeSelf);
    }
    public void CancelOnAutors()
    {
        ButtonMenu.SetActive(!ButtonMenu.activeSelf);
        ButtonAutors.SetActive(!ButtonAutors.activeSelf);
    }
    public void StartPlayFree()
    {
        LoadSceneFree.SetActive(!LoadSceneFree.activeSelf);
    }
    public void StartPlayTime()
    {
        LoadSceneTime.SetActive(!LoadSceneTime.activeSelf);
    }
    public void OnNewGameAfterEnd()
    {
        EndGame.SetActive(!EndGame.activeSelf);
    }

}
