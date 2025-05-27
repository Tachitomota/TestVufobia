using UnityEngine;
using UnityEngine.Events;

public class DanceController : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onActiveSelectDance;
    [SerializeField]
    private UnityEvent _onSelectDance;
    [SerializeField]
    private Animator _characterAnimation;
    private SoundData _currentSoundData;
    public void ActivateSelectDance()
    {
        _onActiveSelectDance?.Invoke();
    }

    public void SelectDance(SoundData soundData)
    {
        _currentSoundData = soundData;
        _onSelectDance?.Invoke();
    }

    public void StartDance()
    {
        _characterAnimation.Play(_currentSoundData.danceName);
        SoundManager.instance.PlayMusic(_currentSoundData.musicName);
    }
}
