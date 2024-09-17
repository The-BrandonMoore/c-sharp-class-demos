using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CH20EFBmdbConsole.Db;
using Microsoft.EntityFrameworkCore;

namespace CH20EFBmdbConsole.Models;

[Table("Actor")]
[Index("FirstName", "LastName", "Birthdate", Name = "UQ_Actor_fn_ln_bd", IsUnique = true)]
public partial class Actor
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Gender { get; set; } = null!;

    public DateOnly Birthdate { get; set; }

    [InverseProperty("Actor")]
    public virtual ICollection<Credit> Credits { get; set; } = new List<Credit>();

    public Actor(string firstName, string lastName, string gender, DateOnly birthdate)
    {
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Birthdate = birthdate;
    }

    public override string ToString()
    {
        return $"Actor Information: {Id}, {FirstName} {LastName}, {Gender}, {Birthdate}";
    }
}
