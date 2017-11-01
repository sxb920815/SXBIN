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
    [Table("Member")]
    public class Member
    {
        [Key]
        public Guid Id { get; set; }

        public string NickName { get; set; }
        public string RealName { get; set; }

        public string ReferrerId { get; set; }
        public string ParentIds { get; set; }
        public string ExtensionCode { get; set; }
        public string MerchantId { get; set; }

        public int Sex { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime Birthday { get; set; }

        public MemberType MemberType { get; set; }

    }

    public enum MemberType
    {
       
        /// <summary>
        /// 普通会员
        /// </summary>
        [Description("普通会员")]

        Member = 1
    }
}
