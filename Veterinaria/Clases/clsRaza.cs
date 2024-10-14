using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Veterinaria.Models;


namespace Veterinaria.Clases
{
    public class clsRaza
    {

        ClinicaVeterinariaEntities1 DBConection = new ClinicaVeterinariaEntities1();
        public Raza raza { get; set; }

        // Consultar una Raza por ID
        public Raza GetRazaByID(int IdRaza)
        {
            return DBConection.Razas.FirstOrDefault(x => x.id_raza == IdRaza); 
        }


        // Consultar todas las razas
        public List<Raza> GetRazas()
        {
            return DBConection.Razas
                .OrderBy(x => x.nombre_raza)
                .ToList();
        }


        // Consultar Razas mediante su especie
        public List<Raza> GetRazasBySpecy(int IdSpecy)
        {
            return DBConection.Razas
                .Where(x => x.id_especie == IdSpecy)
                .OrderBy(x => x.nombre_raza)
                .ToList();
        }


        // Guardar nueva raza
        public string InsertRaza()
        {
            try
            {
                DBConection.Razas.Add(raza);
                DBConection.SaveChanges();

                return "Se guardó correctamente la información de la nueva raza";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        // Eliminar raza
        public string DeleteRaza()
        {
            try
            {
                Raza _raza = GetRazaByID(raza.id_raza);
                if (_raza == null)
                {
                    return "La raza no existe en la base de datos";
                }
                else
                {
                    DBConection.Razas.Remove(_raza);
                    DBConection.SaveChanges();
                    return "Se eliminó el registro de manera exitosa";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        // Actualizar raza
        public string UpdateRaza()
        {
            try
            {
                Raza _raza = GetRazaByID(raza.id_raza);

                DeleteRaza();
                InsertRaza();

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