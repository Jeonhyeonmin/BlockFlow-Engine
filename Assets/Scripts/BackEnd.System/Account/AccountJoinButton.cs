using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BackEnd.System.Account
{
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

        [SerializeField, Tooltip("사용자가 서비스 약관 동의 여부를 체크하는 UI 컴포넌트")]
        private Toggle cTermsToggle;

        [SerializeField, Tooltip("사용자가 개인정보 보호정책 동의 여부를 체크하는 UI 컴포넌트")]
        private Toggle cPrivacyPolicyToggle;

        [SerializeField, Tooltip("계정을 생성하는 버튼 UI 컴포넌트")]
        private Button cCreateAccountButton;

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
    }
}