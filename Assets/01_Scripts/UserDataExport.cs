
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//clase creada para exportar a FireBase
public class UserDataExport
{
    public float Extime;
    public string Exlevel;
    public string ExbuttonPressed;
    public int Excorrect;
    public int Excount;
    public string Exusername;
    public string Exepisode;
    public string Exdate;
    public string Key;

    public UserDataExport()
    {
        Extime = 0;
        Exlevel = "One";
        ExbuttonPressed = "White";
        Excorrect = 0;
        Excount = 0;
        Exusername = "player";
        Exepisode = "none";
        Exdate = "None";
        Key = "0";
    }
    public UserDataExport(float t, string le,string but,int cor, int cou,string user, string ep,string dat,string K)
    {
        Extime = t;
        Exlevel = le;
        ExbuttonPressed = but;
        Excorrect = cor;
        Excount = cou;
        Exusername = user;
        Exepisode = ep;
        Exdate = dat;
        Key = K;
    }

}
