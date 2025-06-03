using UnityEngine;
using UnityEngine.Events;

public class FailChecker : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onNoteDestroyed;

    private void OnTrigerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("note"))
        {
            _onNoteDestroyed?.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
