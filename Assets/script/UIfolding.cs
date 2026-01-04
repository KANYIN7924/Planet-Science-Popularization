using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;
public class UIfolding : MonoBehaviour
{
    //折叠方向
    private enum MoveDir
    {
        Left,
        Right
    }
    [SerializeField]
    private Button _showPanelButton;
    [SerializeField]
    private Button _hidePanelButton;
    [Header("折叠方向")]
    [SerializeField]
    private MoveDir _moveToDir;
    private RectTransform _rectTransform;
    private int temp = 0;
    private Tweener _hideTweener = null;

    public RectTransform RectTransform
    {
        get { return _rectTransform; }
    }
    void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }
    void Start()
    {
        _hidePanelButton.onClick.AddListener(HidePanel);
        _showPanelButton.onClick.AddListener(ShowPanel);
        _showPanelButton.gameObject.SetActive(false);
    }
    public void ShowPanel()
    {
        TogglePanel(true);
    }

    public void HidePanel()
    {
        TogglePanel(false);
    }
    private void TogglePanel(bool isOn)
    {
        switch (_moveToDir)
        {
            case MoveDir.Left:
                temp = 1;
                break;
            case MoveDir.Right:
                temp = -1;
                break;
            default:
                break;
        }
        var disX = isOn ? RectTransform.rect.width * temp : RectTransform.rect.width * -temp;
        var tarPos = RectTransform.anchoredPosition;
        tarPos.x = RectTransform.anchoredPosition.x + disX;
        if (_hideTweener != null)
            _hideTweener.Kill();
        _hideTweener = RectTransform.DOAnchorPosX(tarPos.x, 1f);
        _hideTweener.OnStart(() =>
        {
            if (isOn)
                _showPanelButton.gameObject.SetActive(false);
        });
        _hideTweener.OnComplete(() =>
        {
            if (!isOn)
                _showPanelButton.gameObject.SetActive(true);

        });
    }
    private void OnDestroy()
    {
        _hidePanelButton.onClick.RemoveListener(HidePanel);
        _showPanelButton.onClick.RemoveListener(ShowPanel);
        if (_hideTweener != null)
            _hideTweener.Kill();
    }
}