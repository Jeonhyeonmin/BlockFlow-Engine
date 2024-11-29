using System.Text.RegularExpressions;
using Manager;
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

        #endregion

        [Space(30)]

        [Header("계정 로그인")]
        #region 계정 로그인

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

        #endregion
        
        private UserSignupValidationManager _userSignupValidationManager;
        
        private void Awake()
        {
            Setup();
            AddUIListener();
        }

        private void Setup()
        {
            _userSignupValidationManager = GetComponent<UserSignupValidationManager>();

            ValidateUserCountry();
        }
        
        private void AddUIListener()
        {
            cFirstNameField.onEndEdit.AddListener(Fwuanr5Vdns);
            cLastNameField.onEndEdit.AddListener(Ge7Klglne64Klge5Se);
            cEmailField.onEndEdit.AddListener(Jgeofijf53Fuhsmvjv54673);
            cPasswordField.onEndEdit.AddListener(JfoJmwodjewuf35);
            cConfirmPasswordField.onEndEdit.AddListener(Feusf463Bffeu4F);
            cCreateAccountButton.onClick.AddListener(OnClickCreateAccountButton);
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
        
        private void Fwuanr5Vdns(string aaa447) => UserFirstNameValidation(aaa447);
        private void Ge7Klglne64Klge5Se(string bfsgzWd) => UserLastNameValidation(bfsgzWd);
        private void Jgeofijf53Fuhsmvjv54673(string fsunds342) => UserEmailValidation(fsunds342);
        private void JfoJmwodjewuf35(string t43JtDaff453) => UserPasswordValidation(t43JtDaff453);
        private void Feusf463Bffeu4F(string fef4DYfy3JAaa) => UserConfirmPasswordValidation(fef4DYfy3JAaa);

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

        public void OnClickCreateAccountButton()
        {
            if (UserFirstNameValidation(cFirstNameField.text) && UserLastNameValidation(cLastNameField.text) &&
                UserEmailValidation(cEmailField.text) && UserPasswordValidation(cPasswordField.text) &&
                UserConfirmPasswordValidation(cConfirmPasswordField.text) && cTermsAndPrivacyPolicy.isOn)
            {
                BackendLogin.Instance.CustomSignup(cEmailField.text, _tempPassword);
            }
        }

        private void OnDisable()
        {
            cFirstNameField.onEndEdit.RemoveAllListeners();
            cLastNameField.onEndEdit.RemoveAllListeners();
            cEmailField.onEndEdit.RemoveAllListeners();
            cPasswordField.onEndEdit.RemoveAllListeners();
            cConfirmPasswordField.onEndEdit.RemoveAllListeners();
            cCreateAccountButton.onClick.RemoveAllListeners();
        }
    }
}