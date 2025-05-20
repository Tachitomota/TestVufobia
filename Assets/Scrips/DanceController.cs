using UnityEngine;
using UnityEngine.Events;

public class DanceController : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onActiveSelectDance;
    [SerializeField]
    private UnityEvent _onSelectDance;
    public void ActivateSelectDance()
    {
        _onActiveSelectDance?.Invoke();
    }

    public void SelectDance()
    {
        _onSelectDance?.Invoke();
    }
}
