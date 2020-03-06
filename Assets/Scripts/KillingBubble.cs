using UnityEngine;

public class KillingBubble : MonoBehaviour
{
    [SerializeField]
    private int _addScore = 1;
    [SerializeField]
    private CounterScriptableObject _scoreCounter;
    public int _score=0;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        AddScore();
        Debug.Log("Kill");
        _scoreCounter.AddValue(_addScore);
    }
    private void AddScore()
    {
        _score += 5;
    }
}
