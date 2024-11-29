using System.Text.RegularExpressions;
using Manager;
using Security;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BackEnd.System.Account
{
    [RequireComponent(typeof(UserSignupValidationManager))]
    public class AccountJoinButton : MonoBehaviour
    {
        [Header("계정 생성")]

        #region 계정 생성

        [SerializeField, Tooltip("회원가입 패널")]
        private GameObject accountJoinPanel;

        [SerializeField, Tooltip("사용자가 이름을 입력하는 UI 컴포넌트")]
        private TMP_InputField cFirstNameField;

        [SerializeField, Tooltip("사용자가 성을 입력하는 UI 컴포넌트")]
        private TMP_InputField cLastNameField;

        [SerializeField, Tooltip("사용자가 이메일을 입력하는 UI 컴포넌트")]
        private TMP_InputField cEmailField;

        [SerializeField, Tooltip("사용자가 비밀번호를 입력하는 UI 컴포넌트")]
        private TMP_InputField cPasswordField;

        [SerializeField, Tooltip("사용자가 비밀번호 확인을 입력하는 UI 컴포넌트")]
        private TMP_InputField cConfirmPasswordField;

        [SerializeField, Tooltip("사용자의 서비스 약관과 개인정보 보호정책을 확인하는 UI 컴포넌트")]
        private Toggle cTermsAndPrivacyPolicy;
        
        [SerializeField, Tooltip("사용자가 서비스 약관을 눌렀을 때 상호작용 하는 UI 컴포넌트")]
        private Button cTermsButton;

        [SerializeField, Tooltip("사용자가 개인정보 보호정책을 눌렀을 떄 상호작용 하는 UI 컴포넌트")]
        private Button cPrivacyPolicyButton;

        [SerializeField, Tooltip("계정을 생성하는 버튼 UI 컴포넌트")]
        private Button cCreateAccountButton;
        
        private SystemLanguage _userCountry;

        private string _tempPassword;

        private bool _tempFirstNameValidation;
        private bool _tempLastNameValidation;
        private bool _tempEmailValidation;
        private bool _tempPasswordValidation;
        private bool _tempConfirmPasswordValidation;

        private bool _tempCheckTerms;
        private bool _tempCheckPrivacyPolicy;

        #endregion

        [Space(30)]

        [Header("계정 로그인")]
        #region 계정 로그인
        
        [SerializeField, Tooltip("로그인 패널")]
        private GameObject loginJoinPanel;

        [SerializeField, Tooltip("사용자가 이메일을 입력하는 UI 컴포넌트")]
        private TMP_InputField lEmailField;

        [SerializeField, Tooltip("사용자가 비밀번호를 입력하는 UI 컴포넌트")]
        private TMP_InputField lPasswordField;

        [SerializeField, Tooltip("사용자가 로그인 유지 여부를 체크하는 UI 컴포넌트")]
        private Toggle lKeepLogged;

        [SerializeField, Tooltip("사용자가 비밀번호를 재설정할 수 있는 UI 컴포넌트")]
        private Button lForgotPassword;

        [SerializeField, Tooltip("계정에 로그인하는 버튼 UI 컴포넌트")]
        private Button lLoginAccountButton;

        private bool _tempKeepLogged;

        #endregion
        
        private UserSignupValidationManager _userSignupValidationManager;
        
        private void OnEnable()
        {
            Setup();
            AddUIListener();
            UpdateCreateAccountButton();
            UpdateTermsAndPrivacyPolicyToggle();
        }

        private void Setup()
        {
            if (_userSignupValidationManager == null)
            {
                _userSignupValidationManager = GetComponent<UserSignupValidationManager>();
                ValidateUserCountry();
            }
        }
        
        private void AddUIListener()
        {
            cFirstNameField.onEndEdit.AddListener(_ => UpdateCreateAccountButton());
            cLastNameField.onEndEdit.AddListener(_ => UpdateCreateAccountButton());
            cEmailField.onEndEdit.AddListener(_ => UpdateCreateAccountButton());
            cPasswordField.onEndEdit.AddListener(_ => UpdateCreateAccountButton());
            cConfirmPasswordField.onEndEdit.AddListener(_ => UpdateCreateAccountButton());
            cTermsButton.onClick.AddListener(OnClickTermsButton);
            cPrivacyPolicyButton.onClick.AddListener(OnClickPrivacyPolicyButton);
            cTermsAndPrivacyPolicy.onValueChanged.AddListener(_ => UpdateCreateAccountButton());
            cCreateAccountButton.onClick.AddListener(OnClickCreateAccountButton);
            
            lLoginAccountButton.onClick.AddListener(OnClickLoginButton);
            lEmailField.onValueChanged.AddListener(_ => UpdateLoginButton());
            lPasswordField.onValueChanged.AddListener(_ => UpdateLoginButton());
        }

        private void ValidateUserCountry()
        {
            _userCountry = _userSignupValidationManager.GetUserCountry;

            if ((int)_userCountry == 43)    // Unknown
            {
                // 사용 언어 불일치
                Debug.LogError("사용자의 국가는 해당 프로그램을 지원하지 않습니다.");
                
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPaused = true;
                Debug.Log("에디터 모드 종료 됨");
#endif
            }
        }

        private bool UserFirstNameValidation(string inputFirstName)
        {
            string nameLanguage = _userSignupValidationManager.GetNameLanguage(inputFirstName);
            
            switch (nameLanguage)
            {
                case "Arabic":
                    if (_userCountry.ToString() == "Arabic")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Belarusian":
                    if (_userCountry.ToString() == "Belarusian")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Greek":
                    if (_userCountry.ToString() == "Greek")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Hebrew":
                    if (_userCountry.ToString() == "Hebrew")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Japanese":
                    if (_userCountry.ToString() == "Japanese")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Korean":
                    if (_userCountry.ToString() == "Korean")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Russian":
                    if (_userCountry.ToString() == "Russian")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Latin-Based-Language":
                    if (_userCountry.ToString() == "Latin-Based-Language")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
            }

            return false;
        }
        
        private bool UserLastNameValidation(string inputLastName)
        {
            string nameLanguage = _userSignupValidationManager.GetNameLanguage(inputLastName);
            
            switch (nameLanguage)
            {
                case "Arabic":
                    if (_userCountry.ToString() == "Arabic")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Belarusian":
                    if (_userCountry.ToString() == "Belarusian")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Greek":
                    if (_userCountry.ToString() == "Greek")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Hebrew":
                    if (_userCountry.ToString() == "Hebrew")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Japanese":
                    if (_userCountry.ToString() == "Japanese")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Korean":
                    if (_userCountry.ToString() == "Korean")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Russian":
                    if (_userCountry.ToString() == "Russian")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
                case "Latin-Based-Language":
                    if (_userCountry.ToString() == "Latin-Based-Language")
                    {
                        Debug.Log($"정상적인 이름이 입력되었습니다. | 사용 언어 : {nameLanguage}");
                        return true;
                    }
                    
                    Debug.LogError($"비 정상적인 이름이 입력되었습니다. 유저 국가 : {_userCountry.ToString()} | 사용 언어 : {nameLanguage}");
                    break;
            }

            return false;
        }

        private bool UserEmailValidation(string inputEmail)
        {
            const string emailPattern = @"^[^@\s]+@[^@]+\.[^@]+$";

            if (Regex.IsMatch(inputEmail, emailPattern))
            {
                Debug.Log($"올바른 이메일 형식입니다.");
                return true;
            }
            else
            {
                Debug.LogError("잘못 된 이메일 형식입니다.\n이메일을 다시 확인해주세요.");
                return false;
            }
        }

        private bool UserPasswordValidation(string inputPassword)
        {
            bool hasSpecialChar = Regex.IsMatch(inputPassword, @"[~!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]");
            bool hasUpperCase = Regex.IsMatch(inputPassword, @"[A-Z]");
            bool hasLowerCase = Regex.IsMatch(inputPassword, @"[a-z]");
            bool hasDigit = Regex.IsMatch(inputPassword, @"[0-9]");

            if (hasSpecialChar && hasUpperCase && hasLowerCase && hasDigit)
            {
                Debug.Log("비밀번호를 설정 했습니다.");
                _tempPassword = inputPassword;
                return true;
            }
            else
            {
                Debug.LogError("비밀번호가 조건에 맞지 않습니다.");
                return false;
            }
        }

        private bool UserConfirmPasswordValidation(string inputConfirmPassword)
        {
            if (inputConfirmPassword == _tempPassword)
            {
                Debug.Log("비밀번호가 알맞습니다.");
                return true;
            }
            else
            {
                Debug.LogError("비밀번호가 맞지 않습니다.");
                return false;
            }
        }

        private void OnClickTermsButton()
        {
            _tempCheckTerms = true;
            
            if (_userCountry.ToString() != "Korean")
            {
                Application.OpenURL("https://storage.thebackend.io/d0df93b0586ebcac0e1cbad8ea61b30c15648d9f02a55f6c23624c80e630b1f2/terms2.html");
                Debug.Log("외국인 대상");
            }
            else
            {
                Application.OpenURL("https://storage.thebackend.io/d0df93b0586ebcac0e1cbad8ea61b30c15648d9f02a55f6c23624c80e630b1f2/terms.html");
                Debug.Log("한국인 대상");
            }
            
            UpdateTermsAndPrivacyPolicyToggle();
        }
        
        private void OnClickPrivacyPolicyButton()
        {
            _tempCheckPrivacyPolicy = true;

            if (_userCountry.ToString() != "Korean")
            {
                Application.OpenURL("https://storage.thebackend.io/d0df93b0586ebcac0e1cbad8ea61b30c15648d9f02a55f6c23624c80e630b1f2/privacy2.html");
                Debug.Log("외국인 대상");
            }
            else
            {
                Application.OpenURL("https://storage.thebackend.io/d0df93b0586ebcac0e1cbad8ea61b30c15648d9f02a55f6c23624c80e630b1f2/privacy.html");
                Debug.Log("한국인 대상");
            }

            UpdateTermsAndPrivacyPolicyToggle();
        }

        private void UpdateTermsAndPrivacyPolicyToggle()
        {
            if (_tempCheckTerms && _tempCheckPrivacyPolicy)
                cTermsAndPrivacyPolicy.interactable = true;
            else
                cTermsAndPrivacyPolicy.interactable = false;
        }

        private bool IsFormValid()
        {
            return UserFirstNameValidation(cFirstNameField.text) && UserLastNameValidation(cLastNameField.text) &&
                   UserEmailValidation(cEmailField.text) && UserPasswordValidation(cPasswordField.text) &&
                   UserConfirmPasswordValidation(cConfirmPasswordField.text) && cTermsAndPrivacyPolicy.isOn;
        }

        private void UpdateCreateAccountButton()
        {
            cCreateAccountButton.interactable = IsFormValid();
        }

        private void OnClickCreateAccountButton()
        {
            if (IsFormValid())
            {
                BackendLogin.Instance.CustomSignup(cEmailField.text, _tempPassword);
            }
        }

        private void UpdateLoginButton()
        {
            lLoginAccountButton.interactable =
                !string.IsNullOrEmpty(lEmailField.text) && !string.IsNullOrEmpty(lPasswordField.text);
        }

        private void OnClickLoginButton()
        {
            if (string.IsNullOrEmpty(lEmailField.text) || string.IsNullOrEmpty(lPasswordField.text))
            {
                Debug.LogError("입력 필드를 모두 채워주세요!");
                return;
            }
            
            BackendLogin.Instance.CustomLogin(lEmailField.text, lPasswordField.text, success =>
            {
                if (success)
                {
                    // 로그인 성공
                    Debug.Log("로그인에 성공했습니다.");

                    if (lKeepLogged.isOn)
                    {
                        string encryptedEmail = EncryptionUtility.Encrypt(lEmailField.text);
                        string encryptedPassword = EncryptionUtility.Encrypt(lPasswordField.text);
                        
                        PlayerPrefs.SetString("EncryptedEmail", encryptedEmail);
                        PlayerPrefs.SetString("EncryptedPassword", encryptedPassword);
                        PlayerPrefs.Save();
                    }
                }
                else
                {
                    // 로그인 실패
                    Debug.LogError("로그인에 실패했습니다.");
                    lPasswordField.text = string.Empty;
                    OnClickLoginButton();
                }
            });
        }

        private void OnDisable()
        {
            RemoveAllListenersFromFields();
        }

        private void RemoveAllListenersFromFields()
        {
            cFirstNameField.onEndEdit.RemoveAllListeners();
            cLastNameField.onEndEdit.RemoveAllListeners();
            cEmailField.onEndEdit.RemoveAllListeners();
            cPasswordField.onEndEdit.RemoveAllListeners();
            cConfirmPasswordField.onEndEdit.RemoveAllListeners();
            cTermsButton.onClick.RemoveAllListeners();
            cPrivacyPolicyButton.onClick.RemoveAllListeners();
            cCreateAccountButton.onClick.RemoveAllListeners();
            
            lLoginAccountButton.onClick.RemoveAllListeners();
        }
    }
}