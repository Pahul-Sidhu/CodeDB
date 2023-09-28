using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CommunityApp.Models;

namespace CommunityApp.Models{
    public class Province {
    [Key]
    public string? ProvinceCode { get; set; }
    public string? ProvinceName { get; set; }

}
}