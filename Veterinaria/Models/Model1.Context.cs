﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veterinaria.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClinicaVeterinariaEntities1 : DbContext
    {
        public ClinicaVeterinariaEntities1()
            : base("name=ClinicaVeterinariaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cita> Citas { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetallesFactura> DetallesFacturas { get; set; }
        public virtual DbSet<Diagnostico> Diagnosticos { get; set; }
        public virtual DbSet<Especy> Especies { get; set; }
        public virtual DbSet<EstadosCita> EstadosCitas { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<HistorialMedico> HistorialMedicoes { get; set; }
        public virtual DbSet<Hospitalizacion> Hospitalizacions { get; set; }
        public virtual DbSet<Medicamento> Medicamentos { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<PruebasLaboratorio> PruebasLaboratorios { get; set; }
        public virtual DbSet<Raza> Razas { get; set; }
        public virtual DbSet<Receta> Recetas { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<Tratamiento> Tratamientos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Veterinario> Veterinarios { get; set; }
    }
}
