﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TinaKingSystem.Entities;

[Table("Review")]
internal partial class Review
{
    [Key]
    public int ReviewID { get; set; }

    public int PackageID { get; set; }

    public int EmployeeID { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string TypeofRequest { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Process { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Service { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Material { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Thickness { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ImpactTest { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PostWeld { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FillerMetal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TradeName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ReviewerComment { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ManagerComment { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RequestedInformation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TimeSpent { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Overtime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FollowUpPackage { get; set; }

    [ForeignKey("EmployeeID")]
    [InverseProperty("Reviews")]
    public virtual Employee Employee { get; set; }

    [ForeignKey("PackageID")]
    [InverseProperty("Reviews")]
    public virtual Package Package { get; set; }
}