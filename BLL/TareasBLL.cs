using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Hudelsis_P2_AP1.DAL;
using Hudelsis_P2_AP1.Entidades;

namespace Hudelsis_P2_AP1.BLL
{
    public class TareasBLL
    {
        public static List<Tareas> GetTareas()
        {
            List<Tareas> tareas = new List<Tareas>();
            Contexto contexto = new Contexto();

            try
            {
                tareas = contexto.Tareas.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tareas;
        }
    }
}