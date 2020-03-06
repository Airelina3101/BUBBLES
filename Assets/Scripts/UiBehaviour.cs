using UnityEngine;
using UnityEngine.UI;

public class UiBehaviour : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
	// Start is called before the first frame update
	public void ChangeScore(int score)
	{
		_scoreText.text = score.ToString();
	}
}
