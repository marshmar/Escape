using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GROUP
{
    GROUP_RED = 0,
    GROUP_BLUE,
    GROUP_GREEN
}

public class MapData : MonoBehaviour
{
    #region Varaibles
    [SerializeField]
    // MapID
    int mapID;
    // ���� ���� ���� ����
    GROUP occupationGroup;

    Transform tr;
    GameObject informationPanelObject;

    // ���� ������ ����
    bool isFighting;

    #endregion

    #region Properties
    public int MapID { get; set; }
    public GROUP OccupationGroup { get; set; }
    public bool IsFighting { get; set; }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        occupationGroup = GROUP.GROUP_BLUE;
        isFighting = false;
        informationPanelObject = GameObject.Find("InformationPanel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        informationPanelObject.GetComponent<InformationPanel>().SetTextPanel(tr.position, OccupationGroup, isFighting);
    }
}
