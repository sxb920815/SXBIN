using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXBIN.DB.Model
{
    [Table("AdminUser")]
    public class AdminUser
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("手机号")]
        public string PhoneNumber { get; set; }

        [DisplayName("邮箱")]
        public string Email { get; set; }

        [DisplayName("密码（加密）")]
        public string Password { get; set; }

        [DisplayName("用户名")]
        public string UserName { get; set; }

        [DisplayName("设备编号")]
        public string MobileDevice { get; set; }

        [DisplayName("用户类型")]
        public UserType UserType { get; set; }

        [DisplayName("注册时间")]
        public DateTime CreateTime { get; set; }

        [DisplayName("授权编码（单点登录用）")]
        public string Token { get; set; }

        [DisplayName("是否锁定")]
        public bool IsLocked { get; set; }

        [DisplayName("用户状态")]
        public AdminUserStatus Status { get; set; }
    }
    public enum AdminUserStatus
    {
        /// <summary>
        /// 删除
        /// </summary>
        [Description("删除")]
        Delete = -1,

        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]

        Normal = 1
    }

    public enum UserType
    {
        /// <summary>
        /// 后台用户
        /// </summary>
        [Description("后台用户")]
        Admin = 1,

        /// <summary>
        /// 普通会员
        /// </summary>
        [Description("普通会员")]

        Member = 2
    }

}
