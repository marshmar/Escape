using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public GameObject informationPanelObject;
    // Start is called before the first frame update
    
    public void QuitInformationPanel()
    {
        informationPanelObject.SetActive(false);
    }
}
