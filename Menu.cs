using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
   public void sahnegecis(string bolum_ismi)
    {
        Application.LoadLevel(bolum_ismi);
    }
    public void cikis()
    {
        Application.Quit();
    }
}
