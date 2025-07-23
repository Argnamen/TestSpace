using TMPro;
using UnityEngine;

public class MoveUI : MonoBehaviour
{
    [SerializeField] private TMP_Text m_Text;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset = new Vector3(0, 2f, 0);
    [SerializeField] private float smoothSpeed = 5f;

    [SerializeField] private ShipHit shipHit;

    private RectTransform rectTransform;
    private Camera mainCamera;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (target != null)
        {
            Vector3 screenPos = mainCamera.WorldToScreenPoint(target.position + offset);

            rectTransform.position = Vector3.Lerp(
                rectTransform.position,
                screenPos,
                smoothSpeed * Time.deltaTime
            );

            m_Text.text = shipHit.health.ToString();
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
