using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public GameObject container_NPC;
    public GameObject container_player;
    public Text text_NPC;
    public Text[] text_choices;
    public GameObject kupu;

	// Use this for initialization
	void Start () {
        container_NPC.SetActive(false);
        container_player.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
       
	}

    void Begin()
    {
        VD.OnNodeChange += UpdateUI;
        VD.OnEnd += End;
        VD.BeginDialogue(GetComponent<VIDE_Assign>());
    }

    void UpdateUI(VD.NodeData data)
    {
        container_NPC.SetActive(false);
        container_player.SetActive(false);

        if (data.isPlayer)
        {
            container_player.SetActive(true);

            for (int i = 0; i < text_choices.Length; i++)
            {
                if (i < data.comments.Length)
                {
                    text_choices[i].transform.parent.gameObject.SetActive(true);
                    text_choices[i].text = data.comments[i];
                } else
                {
                    text_choices[i].transform.parent.gameObject.SetActive(false);
                }
            }
            text_choices[0].transform.parent.GetComponent<Button>().Select();
        }
        else
        {
            container_NPC.SetActive(true);
            text_NPC.text = data.comments[data.commentIndex];
        }

    }

    void End(VD.NodeData data)
    {
        container_NPC.SetActive(false);
        container_player.SetActive(false);
        VD.OnNodeChange -= UpdateUI;
        VD.OnEnd -= End;
        VD.EndDialogue();
    }

    void OnDisable()
    {
        if (container_NPC != null)
            End(null);
    }

    public void SetPlayerChoice(int choice)
    {
        VD.nodeData.commentIndex = choice;
        if (Input.GetMouseButtonUp(0))
            VD.Next();
    }

    public void SceneChangeminigame()
    {
        SceneManager.LoadScene("minigame");
        Debug.Log("ganti scene");
    }

    public void TriggerTalk ()
    {
         if (Input.GetMouseButtonUp(0)) //left click on mouse to talk
        {
            if (!VD.isActive)
            {
                Begin();
            } else
            {
                VD.Next();
            }
        }
    }
}
