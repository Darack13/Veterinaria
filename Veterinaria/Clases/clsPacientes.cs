using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Veterinaria.Models;


namespace Veterinaria.Clases
{
    public class clsPacientes
    {

        ClinicaVeterinariaEntities1 DBConection = new ClinicaVeterinariaEntities1();
        public Paciente paciente { get; set; }

        // Consultar un paciente por ID
        public Paciente GetPacienteByID(int IdPaciente)
        {
            return DBConection.Pacientes.FirstOrDefault(x => x.id_paciente == IdPaciente); 
        }

        
        // Consultar todos los pacientes
        public List<Paciente> GetPacientes()
        {
            return DBConection.Pacientes
                .OrderBy(x => x.nombre)
                .ToList();
        }


        // Guardar nuevo paciente
        public string InsertPaciente()
        {
            try
            {
                DBConection.Pacientes.Add(paciente);
                DBConection.SaveChanges();

                return "Se guardó correctamente la información del nuevo paciente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        // Eliminar paciene
        public string DeletePaciente()
        {
            try
            {
                Paciente _paciente= GetPacienteByID(paciente.id_paciente);
                if (_paciente == null)
                {
                    return "El paciente no existe en la base de datos";
                }
                else
                {
                    DBConection.Pacientes.Remove(_paciente);
                    DBConection.SaveChanges();
                    return "Se eliminó el registro de manera exitosa";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        // Actualizar paciente
        public string UpdatePaciente()
        {
            try
            {
                Paciente _paciente = GetPacienteByID(paciente.id_paciente);

                DeletePaciente();
                InsertPaciente();

                DBConection.SaveChanges();
                return "Se actualizaron los datos de manera correcta";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}