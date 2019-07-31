using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PohonSceneChange : MonoBehaviour {

    public GameObject panelPohon;

    public GameObject anggrekhutan;
    public GameObject bungarafles;
    public GameObject pohonliana;
    public GameObject pohonmeranti;
    public GameObject pakuan;

    void sceneanggrekhutan()
    {
        panelPohon.SetActive(false);
        anggrekhutan.SetActive(true);

    }

    void scenebungarafles()
    {
        panelPohon.SetActive(false);
        bungarafles.SetActive(true);
    }


}
