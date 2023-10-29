using TMPro;
using UnityEngine.UI;

public class Cell_UI : BtnSubscriber
{
    private int sceneIndex;

    private BtnLoadScene btnLoadScene;
    private TextMeshProUGUI txtComponent;

    private PanelChooseParametrsLvl panelChooseParametrsLvl;

    public void Initialize(int num)
    {
        btn = GetComponent<Button>();
        btnLoadScene = GetComponent<BtnLoadScene>();
        
        txtComponent = GetComponentInChildren<TextMeshProUGUI>();
        txtComponent.text = num.ToString();
        
        btnLoadScene.SetIndex(num);
        sceneIndex = num;

        panelChooseParametrsLvl = FindObjectOfType<PanelChooseParametrsLvl>(true);
    }

    public void SetActiveBtn(bool active)
    {
        btn.interactable = active;
    }

    protected override void Execute()
    {
        panelChooseParametrsLvl.GameObject.SetActive(true);
        panelChooseParametrsLvl.LoadSceneAsync(sceneIndex);
        //SceneManager.LoadSceneAsync(sceneIndex);       
    }
}
