using UnityEngine;

public class YesNoController : MonoBehaviour
{
    [SerializeField]
    private GameObject _handMenu;

    [SerializeField]
    private GameObject _yesObject;

    [SerializeField]
    private GameObject _noObject;
    [SerializeField]

    private Vector3 _targetScale = new Vector3(0.01f, 0.01f, 0.01f);

    void Start()
    {
        _yesObject.transform.localScale = Vector3.zero;
        _noObject.transform.localScale = Vector3.zero;

        _yesObject.SetActive(false);
        _noObject.SetActive(false);
    }

    private void Update()
    {
        transform.position = _handMenu.transform.position;
        transform.rotation = _handMenu.transform.rotation;
    }

    public void ShowYes() 
    {
        ShowObject(_yesObject);
    }

    public void ShowNo()
    {
        ShowObject(_noObject);
    }

    private void ShowObject(GameObject objectToShow)
    {
        objectToShow.transform.localScale = Vector3.zero;
        objectToShow.SetActive(true);
        LeanTween.scale(objectToShow, _targetScale, 0.5f).setLoopPingPong(1).setOnComplete(() => objectToShow.SetActive(false));
    }
}
