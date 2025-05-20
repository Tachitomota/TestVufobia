using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class ButtonControler : MonoBehaviour
{
    [SerializeField]

    private List<GameObject>  _buttons;

    [SerializeField]
    private string _apperedAnimationName;

    [SerializeField]
    private string _DisapirAnimationName;

    [SerializeField]
    private float _buttonsAppearDelay;

    public void ShowButtons(){
        StartCoroutine(ShowButtonsWithDelay());
    }
    private IEnumerator ShowButtonsWithDelay(){
        foreach(GameObject button in _buttons){
            button.GetComponent<Animator>().Play(_apperedAnimationName);
            yield return new WaitForSeconds (_buttonsAppearDelay);
        }

    }

    public void HiddenButtons(){
        foreach (GameObject button in _buttons) {
            button.GetComponent<Animator>().Play(_DisapirAnimationName);
        }
    }


}
