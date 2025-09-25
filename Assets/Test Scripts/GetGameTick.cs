using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetGameTick : MonoBehaviour
{
    #region Manager Dependencies
    LazyDependency<GameManager> _gameManger;
    GameManager GameManager => _gameManger.Value;
    #endregion

    #region Editor Values
    [SerializeField] Button SetGameTicks;
    [SerializeField] TextMeshProUGUI TickText;
    #endregion

    private void Awake()
    {
        SetGameTicks.onClick.AddListener(SetTickText);
    }

    private void SetTickText()
    {
        TickText.text = $"{GameManager.CurrentTick}";
    }
}
