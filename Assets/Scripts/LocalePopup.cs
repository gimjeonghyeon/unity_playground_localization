using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocaleManager : MonoBehaviour
{
    private bool isChanging;

    public void ChangeLocale(int index)
    {
        if (isChanging)
        {
            return;
        }

        StartCoroutine(DoChangeLocale(index));
    }

    private IEnumerator DoChangeLocale(int index)
    {
        isChanging = true;
        
        // Localization 시스템의 초기화, Locales 로드, assets 프리로딩 등이 완료될 때까지 기다리기
        //  InitializationOperation이 완료되기 전에 LocalizationSettings.SelectedLocale 이 null값을 반환할 수 있음.
        yield return LocalizationSettings.InitializationOperation;

        // index를 통해 SelectedLocale 설정
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
        
        isChanging = false;
    }
}
