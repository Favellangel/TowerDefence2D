
public class SelectComponent 
{
    private ISelecteble selectedObject;

    public void Select(ISelecteble selecteble)
    {
        selectedObject?.Deselect();

        selectedObject = selecteble;
        selectedObject?.Select();
    }

    public void Deselect()
    {
        if (selectedObject == null) return;
        selectedObject.Deselect();
        selectedObject = null;
    }
}
