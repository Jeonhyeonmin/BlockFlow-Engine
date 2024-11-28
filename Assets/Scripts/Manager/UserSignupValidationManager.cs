using UnityEngine;

namespace Manager
{
    public class UserSignupValidationManager : MonoBehaviour
    {
        public SystemLanguage GetUserCountry => DetectCountry();
        private SystemLanguage DetectCountry()
        {
            return Application.systemLanguage;
        }

        public string GetNameLanguage(string userName) => IdentifyNameLanguage(userName);

        private string IdentifyNameLanguage(string userName)
        {
            foreach (var character in userName)
            {
                if (IsArabicCharacter(character)) return "Arabic";
                if (IsBelarusianCharacter(character)) return "Belarusian";
                if (IsBulgarianCharacter(character)) return "Bulgarian";
                if (IsGreekCharacter(character)) return "Greek";
                if (IsHebrewCharacter(character)) return "Hebrew";
                if (IsJapaneseCharacter(character)) return "Japanese";
                if (IsKoreanCharacter(character)) return "Korean";
                if (IsRussianCharacter(character)) return "Russian";

                if (IsLatinBasedLanguageCharacter(character)) return "Latin-Based-Language"; // 그룹으로 묶음
            }

            return "Unknown";
        }

        private bool IsArabicCharacter(char character) => character >= 0x0600 && character <= 0x06FF; // Arabic
        private bool IsBelarusianCharacter(char character) => character >= 0x0400 && character <= 0x04FF; // Cyrillic
        private bool IsBulgarianCharacter(char character) => character >= 0x0400 && character <= 0x04FF; // Cyrillic
        private bool IsGreekCharacter(char character) => character >= 0x0370 && character <= 0x03FF; // Greek
        private bool IsHebrewCharacter(char character) => character >= 0x0590 && character <= 0x05FF; // Hebrew
        private bool IsJapaneseCharacter(char character) =>
            (character >= 0x3040 && character <= 0x309F) || // Hiragana
            (character >= 0x30A0 && character <= 0x30FF) || // Katakana
            (character >= 0x4E00 && character <= 0x9FBF);   // Kanji
        private bool IsKoreanCharacter(char character) => character >= 0xAC00 && character <= 0xD7A3; // Hangul Syllables
        private bool IsRussianCharacter(char character) => character >= 0x0400 && character <= 0x04FF; // Cyrillic

        private bool IsLatinBasedLanguageCharacter(char character) => 
            IsLatinCharacter(character) || IsLanguageSpecificLatinCharacter(character);

        private bool IsLatinCharacter(char character) => 
            (character >= 'A' && character <= 'Z') || (character >= 'a' && character <= 'z');

        private bool IsLanguageSpecificLatinCharacter(char character)
        {
            // 특수 문자를 각 언어 그룹에서 처리
            return IsCzechSpecificCharacter(character) ||
                   IsVietnameseSpecificCharacter(character) ||
                   // 기타 라틴 기반 언어에 대한 특수 문자 추가
                   character == 'é' || character == 'ø' || character == 'ç';
        }

        private bool IsCzechSpecificCharacter(char character) => character == 'ě' || character == 'š' || character == 'č' || character == 'ř';
        private bool IsVietnameseSpecificCharacter(char character) => character == 'ắ' || character == 'ấ' || character == 'ậ' || character == 'đ';
    }
}