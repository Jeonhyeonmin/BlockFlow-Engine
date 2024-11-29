using System;
using System.Text.RegularExpressions;
using UnityEngine;
using Manager.etc;

namespace BackEnd.System.Account
{
    /// <summary>
    /// 이 스크립트의 모든 메서드는 "반드시" 서버 초기화가 성공한 이후에만 실행되어야 합니다.
    /// All methods in this script "must" be executed only after the server initialization is successful.
    /// </summary>
    public class BackendLogin : SingletonManagerSystem<BackendLogin>
    {
        /// <summary>
        /// 사용자 회원가입을 위한 커스텀 메서드
        /// Custom sign-up method for user registration.
        /// </summary>
        /// <param name="id">사용자 ID / User ID</param>
        /// <param name="pw">사용자 비밀번호 / User Password</param>
        public void CustomSignup(string id, string pw)
        {
            Debug.Log("회원가입을 요청합니다.\nRequesting user registration.");

            Backend.BMember.CustomSignUp(id, pw, callback =>
            {
                if (callback.IsSuccess())
                {
                    Debug.Log($"회원가입에 성공하였습니다. : {id}\nUser registration successful: {id}");
                }
                else
                {
                    Debug.LogError($"회원가입에 실패하였습니다. : {id} : \n{callback.Message}\nUser registration failed: {id} : \n{callback.Message}");
                }
            });
        }

        /// <summary>
        /// 사용자 로그인을 위한 커스텀 메서드
        /// Custom login method for user authentication.
        /// </summary>
        /// <param name="id">사용자 ID / User ID</param>
        /// <param name="pw">사용자 비밀번호 / User Password</param>
        /// <param name="callback"></param>
        public void CustomLogin(string id, string pw, Action<bool> callback)
        {
            Debug.Log("로그인을 요청합니다.\nRequesting user login.");

            Backend.BMember.CustomLogin(id, pw, loginResponse =>
            {
                if (loginResponse.IsSuccess())
                {
                    Debug.Log($"로그인에 성공하였습니다. : {id}\nLogin successful: {id}");
                    callback(true);
                }
                else
                {
                    Debug.LogError($"로그인에 실패하였습니다. : {id} : \n{loginResponse.Message}\nLogin failed: {id} : \n{loginResponse.Message}");
                    callback(false);
                }
            });
        }

        /// <summary>
        /// 사용자 닉네임을 변경하는 메서드 (로그인 이후에만 실행 가능)
        /// Method to update the user's nickname (must be executed after login).
        /// </summary>
        /// <param name="nickname">새 닉네임 / New nickname</param>
        public void UpdateNickname(string nickname)
        {
            Debug.Log("닉네임 변경을 요청합니다.\nRequesting nickname update.");

            Backend.BMember.UpdateNickname(nickname, callback =>
            {
                if (callback.IsSuccess())
                {
                    Debug.Log($"닉네임이 성공적으로 변경되었습니다. : {nickname}\nNickname updated successfully: {nickname}");
                }
                else
                {
                    Debug.LogError($"닉네임 변경에 실패하였습니다. : {nickname} : {callback.Message}\nFailed to update nickname: {nickname} : {callback.Message}");
                }
            });
        }

        public void ResetCustomPassword(string emailAddress, Action<bool> callback)
        {
            const string emailPattern = @"^[^@\s]+@[^@]+\.[^@]+$";
            
            if (!string.IsNullOrEmpty(emailAddress) && Regex.IsMatch(emailAddress, emailPattern))
            {
                Backend.BMember.ResetPassword(emailAddress, emailAddress, emailResult =>
                {
                    if (emailResult.IsSuccess())
                    {
                        Debug.Log($"{emailAddress} 주소로 메일을 발송하였습니다.");
                        callback(true);
                    }
                    else
                    {
                        Debug.LogError($"{emailAddress} 주소로 전송되지 않았습니다. {emailResult.Message}");
                        callback(false);
                    }
                });
            }
        }
    }
}
