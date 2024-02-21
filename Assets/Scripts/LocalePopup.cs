using System.Collections;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LocaleManager : MonoBehaviour
{
    private bool isChanging;

    private void Start()
    {
        // SelectedLocale이 변경되었을 때 호출되는 이벤트 등록
        LocalizationSettings.SelectedLocaleChanged += LocalizationSettingsOnSelectedLocaleChanged;
    }

    private void LocalizationSettingsOnSelectedLocaleChanged(Locale locale)
    {
        // TODO: Locale이 변경되었을 때 처리가 필요한 내용 작성
    }

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
        // InitializationOperation이 완료되기 전에 LocalizationSettings.SelectedLocale 이 null값을 반환할 수 있음.
        yield return LocalizationSettings.InitializationOperation;

        // index를 통해 SelectedLocale 설정
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
        
        isChanging = false;
    }

    /// <summary>
    /// Localization 데이터에 직접 접근하여 string을 가져오기
    /// </summary>
    /// <returns></returns>
    public string GetString()
    {
        string tableName = "Playground Table";
        string key = "UI_TITLE";
        var selectedLocale = LocalizationSettings.SelectedLocale;

        return LocalizationSettings.StringDatabase.GetLocalizedString(tableName, key, selectedLocale);
    }
}
