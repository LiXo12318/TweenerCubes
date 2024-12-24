using UnityEngine;
using DG.Tweening;

public class CubeAnimation : MonoBehaviour
{
    private static class AnimationDefaults
    {
        public const float RotationDuration = 2f;
        public static readonly Vector3 RotationAngle = new Vector3(0f, 360f, 0f);
        public const RotateMode RotationMode = RotateMode.FastBeyond360;
        public const Ease RotationEase = Ease.InOutElastic;

        public const float PunchDuration = 1f;
        public static readonly Vector3 PunchStrength = new Vector3(1f, 1f, 1f);
        public const int PunchVibrato = 10;
        public const float PunchElasticity = 1f;
        public const Ease PunchEase = Ease.InOutBounce;
    }

    [Header("Rotation Animation Settings")]
    [SerializeField] private float rotationDuration = AnimationDefaults.RotationDuration;
    [SerializeField] private Vector3 rotationAngle = AnimationDefaults.RotationAngle;
    [SerializeField] private RotateMode rotationMode = AnimationDefaults.RotationMode;
    [SerializeField] private Ease rotationEase = AnimationDefaults.RotationEase;

    [Header("Punch Scale Animation Settings")]
    [SerializeField] private float punchDuration = AnimationDefaults.PunchDuration;
    [SerializeField] private Vector3 punchStrength = AnimationDefaults.PunchStrength;
    [SerializeField] private int punchVibrato = AnimationDefaults.PunchVibrato;
    [SerializeField] private float punchElasticity = AnimationDefaults.PunchElasticity;
    [SerializeField] private Ease punchEase = AnimationDefaults.PunchEase;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log($"<color=green>[Key Pressed]</color>: 1, <color=blue>[Action]</color>: Rotate Cube");
            RotateCube();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log($"<color=green>[Key Pressed]</color>: 2, <color=blue>[Action]</color>: Punch Scale");
            PunchScale();
        }
    }

    private void RotateCube()
    {
        transform.DORotate(rotationAngle, rotationDuration, rotationMode)
                .SetEase(rotationEase);
    }

    private void PunchScale()
    {
        transform.DOPunchScale(punchStrength, punchDuration, punchVibrato, punchElasticity)
                .SetEase(punchEase);
    }
}
