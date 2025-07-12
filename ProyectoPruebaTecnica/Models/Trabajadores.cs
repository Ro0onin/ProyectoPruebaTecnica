using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoPruebaTecnica.Models;

public partial class Trabajadores
{
    public int Id { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? Nombres { get; set; }

    public string? Sexo { get; set; }

    public int? IdDepartamento { get; set; }

    public int? IdProvincia { get; set; }

    public int? IdDistrito { get; set; }

    [Display(Name = "Departamento")]
    public virtual Departamento? IdDepartamentoNavigation { get; set; }

    [Display(Name = "Distrito")]
    public virtual Distrito? IdDistritoNavigation { get; set; }

    [Display(Name = "Provincia")]
    public virtual Provincia? IdProvinciaNavigation { get; set; }
}
