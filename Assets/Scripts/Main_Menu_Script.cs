// Ignore Spelling: Panal
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu_Script : MonoBehaviour
{
    public GameObject Main_Menu_Panal;
    public GameObject Settings_Panal;
    public GameObject Play_Game_Panal;
    
    private void Start()
    {
        Settings_Panal.SetActive(false);
        Play_Game_Panal.SetActive(false);
        Main_Menu_Panal.SetActive(true);
    }
    
    public void settings_btn_pressed()
    {
        Main_Menu_Panal.SetActive(false);
        Play_Game_Panal.SetActive(false);
        Settings_Panal.SetActive(true);
    }
    
    public void back_Btn_Pressed()
    {
        Main_Menu_Panal.SetActive(true);
        Play_Game_Panal.SetActive(false);
        Settings_Panal.SetActive(false);
    }
    
    public void play_game_btn_Pressed()
    {
        Main_Menu_Panal.SetActive(false);
        Settings_Panal.SetActive(false);
        Play_Game_Panal.SetActive(true);
    }

    public void terrain_Btn_Pressed()
    {
        SceneManager.LoadScene("1");
    }
    
    public void quit_btn_pressed()
    {
        Application.Quit(1);
    }
}