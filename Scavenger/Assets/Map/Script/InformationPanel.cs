using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformationPanel : MonoBehaviour
{
    private RectTransform tr;
    public TMP_Text OccupationGroupText;
    public TMP_Text IsFightingText;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTextPanel(Vector3 mapPos, GROUP OccupationGroup, bool isFighting)
    {
        Debug.Log(tr.anchoredPosition);
        tr.anchoredPosition = new Vector3(mapPos.x, mapPos.y, mapPos.z);
        Debug.Log(tr.anchoredPosition);
        OccupationGroupText.text = OccupationGroup.ToString();
        IsFightingText.text = isFighting == true ? "True" : "False";
    }
    
}
