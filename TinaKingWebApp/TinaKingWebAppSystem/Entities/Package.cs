﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TinaKingSystem.Entities;

[Table("Package")]
internal partial class Package
{
    [Key]
    public int PackageID { get; set; }

    public int ClientID { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string TypeofRequest { get; set; }

    public int PackageNumber { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string DocumentName { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string DocumentNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Priority { get; set; }

    [Column(TypeName = "date")]
    public DateTime Deadline { get; set; }

    [Column(TypeName = "date")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime EndDate { get; set; }

    public int? FollowUpPackage { get; set; }

    [ForeignKey("ClientID")]
    [InverseProperty("Packages")]
    public virtual Client Client { get; set; }

    [InverseProperty("Package")]
    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    [InverseProperty("Package")]
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}