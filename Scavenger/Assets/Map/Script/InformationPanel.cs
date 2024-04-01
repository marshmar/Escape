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

    /// <summary>
    /// TextPanel의 값을 설정하는 함수
    /// </summary>
    /// <param name="mapPos">Panel을 옮길 위치</param>
    /// <param name="OccupationGroup">점령 세력을 나타낼 세력</param>
    /// <param name="isFighting">전쟁 중인지 여부</param>
    public void SetTextPanel(Vector3 mapPos, GROUP OccupationGroup, bool isFighting)
    {
        tr.anchoredPosition = Camera.main.WorldToScreenPoint(mapPos);
        Debug.Log(tr.anchoredPosition);
        OccupationGroupText.text = OccupationGroup.ToString();
        IsFightingText.text = isFighting == true ? "True" : "False";
    }
    
}
