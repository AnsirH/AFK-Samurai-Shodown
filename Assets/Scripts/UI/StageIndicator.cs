using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class StageIndicator : MonoBehaviour
{
    RectTransform[] rectTrfs;
    Image[] images;
    Text[] texts;

    [Header("메인 이미지")]
    [SerializeField]
    float mainImageMoveValue;
    [SerializeField]
    float mainImageMoveTime;

    [Header("서브 이미지")]
    [SerializeField]
    float subImageMoveValue;
    [SerializeField]
    float subImageMoveTime;

    [Header("스테이지 넘버 텍스트"), SerializeField]
    Text stageNumberText;

    private void Awake()
    {
        rectTrfs = GetComponentsInChildren<RectTransform>();
        images = GetComponentsInChildren<Image>();
        texts = GetComponentsInChildren<Text>();

        foreach(var image in images)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        }
        foreach (var text in texts)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, 0f);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowStage(10);
        }
    }

    public void ShowStage(int stageNumber)
    {
        gameObject.SetActive(true);
        stageNumberText.text = stageNumber.ToString();

        for (int i = 0; i < rectTrfs.Length; i++)
        {
            if (i == 0)
            {
                rectTrfs[i].DOAnchorPosX(mainImageMoveValue, mainImageMoveTime, true).From();
                continue;
            }
            rectTrfs[i].DOAnchorPosX(rectTrfs[i].anchoredPosition.x + subImageMoveValue, subImageMoveTime, true).SetDelay(mainImageMoveTime).From();
        }

        for (int i = 0; i < images.Length; i++)
        {
            images[i].DOFade(1f, 0.2f).SetDelay(mainImageMoveTime + subImageMoveTime).From();
        }

        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].DOFade(1f, 0.2f).SetDelay(mainImageMoveTime + subImageMoveTime).From();
        }
    }
}
