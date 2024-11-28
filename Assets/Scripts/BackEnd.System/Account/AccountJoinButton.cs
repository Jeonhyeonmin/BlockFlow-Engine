using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AccountJoinButton : MonoBehaviour
{
    [Header("계정 생성")]
    #region 계정 생성

    [SerializeField, Tooltip("사용자가 이름을 입력하는 UI 컴포넌트")]
    private TMP_InputField c_firstNameField;

    [SerializeField, Tooltip("사용자가 성을 입력하는 UI 컴포넌트")]
    private TMP_InputField c_lastNameField;

    [SerializeField, Tooltip("사용자가 이메일을 입력하는 UI 컴포넌트")]
    private TMP_InputField c_emailField;

    [SerializeField, Tooltip("사용자가 비밀번호를 입력하는 UI 컴포넌트")]
    private TMP_InputField c_passwordField;

    [SerializeField, Tooltip("사용자가 비밀번호 확인을 입력하는 UI 컴포넌트")]
    private TMP_InputField c_confirmPasswordField;

    [SerializeField, Tooltip("사용자가 서비스 약관 동의 여부를 체크하는 UI 컴포넌트")]
    private Toggle c_termsToggle;

    [SerializeField, Tooltip("사용자가 개인정보 보호정책 동의 여부를 체크하는 UI 컴포넌트")]
    private Toggle c_privacypolicyToggle;

    [SerializeField, Tooltip("계정을 생성하는 버튼 UI 컴포넌트")]
    private Button c_create_AccountButton;

    #endregion

    [Space(30)]

    [Header("계정 로그인")]
    #region 계정 로그인

    [SerializeField, Tooltip("사용자가 이메일을 입력하는 UI 컴포넌트")]
    private TMP_InputField l_emailField;

    [SerializeField, Tooltip("사용자가 비밀번호를 입력하는 UI 컴포넌트")]
    private TMP_InputField l_passwordField;

    [SerializeField, Tooltip("사용자가 로그인 유지 여부를 체크하는 UI 컴포넌트")]
    private Toggle l_KeepLogged;

    [SerializeField, Tooltip("사용자가 비밀번호를 재설정할 수 있는 UI 컴포넌트")]
    private Button l_ForgotPassword;

    [SerializeField, Tooltip("계정에 로그인하는 버튼 UI 컴포넌트")]
    private Button l_Login_AccountButton;

    #endregion
}