using System;
using System.ComponentModel.DataAnnotations;

namespace SPhone.Models.Manage
{
  public class EditExtraProfileModel
  {
      [Display(Name = "Họ và tên")]
      public string UserName { get; set; }

      [Display(Name = "Địa chỉ email")]
      public string UserEmail { get; set; }
      [Display(Name = "Số điện thoại")]
      public string PhoneNumber { get; set; }

      [Display(Name = "Địa chỉ")]
      [StringLength(400)]
      public string HomeAdress { get; set; }


      [Display(Name = "Ngày sinh")]
      public DateTime? BirthDay { get; set; }
  }
}