using UnityEngine;
using UnityEngine.SceneManagement;

public class CellsLvlLoader : MonoBehaviour, IBindable
{
    [SerializeField] private GameObject cellPrefab;

    private MenuDatasBehavior menuDatasBehavior;

    public void Bind()
    {
        menuDatasBehavior = FindObjectOfType<MenuDatasBehavior>();
        int Lvls = SceneManager.sceneCountInBuildSettings - 1;

        for (int i = 1; i <= Lvls; i++)
        {
            GameObject cell = Instantiate(cellPrefab, transform);

            Cell_UI cellScript = cell.GetComponent<Cell_UI>();
            cellScript.Initialize(i); 
            bool isActiveBtn = menuDatasBehavior.CountOpenLvl >= i;
            cellScript.SetActiveBtn(isActiveBtn);
        }
    }
}
