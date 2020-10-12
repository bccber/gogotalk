using System;

namespace GoGoTalk.Models
{
    public class StatusConst
    {
        public enum ResultCode : Int32
        {
            /// <summary>
            /// 失败
            /// </summary>
            Failure = 0,

            /// <summary>
            /// 成功
            /// </summary>
            Successful = 1,

            /// <summary>
            /// 用户已存在
            /// </summary>
            UserExists = 2,

            /// <summary>
            /// 重复登录
            /// </summary>
            RepeatLogin = 3,

            /// <summary>
            /// 用户不存在
            /// </summary>
            UserNotExists = 4,

            /// <summary>
            /// 密码错误
            /// </summary>
            WrongPassword = 5,
        };
    }
}
