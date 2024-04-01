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
    /// TextPanel�� ���� �����ϴ� �Լ�
    /// </summary>
    /// <param name="mapPos">Panel�� �ű� ��ġ</param>
    /// <param name="OccupationGroup">���� ������ ��Ÿ�� ����</param>
    /// <param name="isFighting">���� ������ ����</param>
    public void SetTextPanel(Vector3 mapPos, GROUP OccupationGroup, bool isFighting)
    {
        tr.anchoredPosition = Camera.main.WorldToScreenPoint(mapPos);
        Debug.Log(tr.anchoredPosition);
        OccupationGroupText.text = OccupationGroup.ToString();
        IsFightingText.text = isFighting == true ? "True" : "False";
    }
    
}
