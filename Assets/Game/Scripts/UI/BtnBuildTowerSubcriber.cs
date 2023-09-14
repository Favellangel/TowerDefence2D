using UnityEngine;
using UnityEngine.UI;

public class BtnBuildTowerSubcriber : MonoBehaviour
{
    [SerializeField] private int costTower;
    [SerializeField] private GameObject tower;

    private GoldComponent goldComponent;
    private PanelBuildTowerController panelBuildTowerController;

    private void OnEnable()
    {
        GetComponent<Button>().onClick.AddListener(Execute); 
        panelBuildTowerController = FindObjectOfType<PanelBuildTowerController>(true);

        goldComponent = FindObjectOfType<GoldComponent>(true);
    }
     
    private void Execute()
    {        
        if(goldComponent.SubGold(costTower))
        {
            Instantiate(tower, panelBuildTowerController.transform.position, Quaternion.identity);
        }
        transform.parent.gameObject.SetActive(false);       
    }
}
