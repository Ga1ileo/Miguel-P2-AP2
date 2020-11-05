using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Miguel_P2_AP2.DAL;
using Miguel_P2_AP2.Models;

namespace Miguel_P2_AP2.BLL
{
    public class VentasBLL
    {
        public static Ventas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ventas ventas;

            try
            {
                ventas = contexto.Ventas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return ventas;

        }
        public static List<Ventas> GetList()
        {
            List<Ventas> lista = new List<Ventas>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Ventas.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return lista;
        }
    }
}
