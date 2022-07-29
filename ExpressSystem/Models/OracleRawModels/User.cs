using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    /// <summary>
    /// User模型   储存用户的登录信息  即账号密码角色
    /// </summary>
    public class User
    {
        [Required(ErrorMessage ="请输入账号")]
        [RegularExpression("^[0-9]{5,7}$",ErrorMessage ="账号格式错误(5位或7位数字)")]
        [Display(Name = "账号")]
        public string ID { get; set; }

        [Required(ErrorMessage = "请输入密码")]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,20}$", ErrorMessage = "密码格式错误(大小写字母＋数字,长度为8-20)")]
        [Display(Name = "密码")]
        public string PASSWORD { get; set; }

        [Required(ErrorMessage = "请选择角色")]
        [Display(Name = "角色")]
        public string ROLE { get; set; }
    }


    public enum RoleEnum { 
        用户,
        快递员,
        司机,
        代收点,
        转运中心,
        快递公司
    }
}
