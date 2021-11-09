using UnityEngine;

public class SliderScript : MonoBehaviour
{
    public Animator animator;
    public UnityEngine.UI.Slider mainSlider;
    public UnityEngine.UI.Text sliderText;

    void Start()
    {
        mainSlider.onValueChanged.AddListener((v) =>
            {
                sliderText.text = v.ToString("0.00");
                animator.SetFloat("Blend", v);
            }
        );
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
