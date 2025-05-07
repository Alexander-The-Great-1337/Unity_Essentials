using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
  [Header("Day-Night Settings")]
  [Tooltip("Duration of a full 24h cycle in real-time seconds")]
  public float fullDayLengthInSeconds = 120f;

  [Tooltip("Initial time of day (0 = midnight, 12 = noon)")]
  [Range(0f, 24f)]
  public float startTimeOfDay = 6f;

  private float currentTimeOfDay; // 0 to 24
  private float timeMultiplier;   // How fast in-game time passes

  void Start()
  {
    currentTimeOfDay = startTimeOfDay;
    timeMultiplier = 24f / fullDayLengthInSeconds;
  }

  void Update()
  {
    currentTimeOfDay += Time.deltaTime * timeMultiplier;
    if (currentTimeOfDay >= 24f)
      currentTimeOfDay = 0f;

    UpdateSunRotation();
  }

  void UpdateSunRotation()
  {
    // Rotate around the X-axis: 0h = -90°, 12h = 90°, 24h = 270°
    float sunAngle = (currentTimeOfDay / 24f) * 360f - 90f;
    transform.rotation = Quaternion.Euler(sunAngle, 170f, 0f);
  }
}
