using TMPro;

public class UIManager : MonoSingleton<UIManager>
{
    public TextMeshProUGUI LevelText;

    private void Start()
    {
        SetText();
    }

    public void SetText()
    {
        LevelText.text = "LEVEL" + LevelManager.Instance.CurrentLevel + " - " + LevelManager.Instance.CurrentStage.ToString();
    }
}
