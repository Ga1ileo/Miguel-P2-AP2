using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Miguel_P2_AP2.DAL;
using Miguel_P2_AP2.Models;

namespace Miguel_P2_AP2.BLL
{
    public class CobrosBLL
    {
        public async static Task<bool> Guardar(Cobros cobro)
        {
            return await Insertar(cobro);
        }

        public async static Task<bool> Insertar(Cobros cobro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            cobro.CobroId = 0;
            try
            {
                contexto.Cobros.Add(cobro);
                paso = await contexto.SaveChangesAsync() > 0;

                if (paso)
                {
                    foreach (var cobroDetalle in cobro.CobrosDetalle)
                    {
                        var venta = await VentasBLL.Buscar(cobroDetalle.VentaId);
                        if (venta != null)
                        {
                            venta.Balance -= cobroDetalle.Monto;
                            await VentasBLL.Modificar(venta);
                        }
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await contexto.DisposeAsync();
            }

            return paso;
        }

        public async static Task<bool> Modificar(Cobros cobro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            await contexto.Database.ExecuteSqlRawAsync($"DELETE FROM CobroDetalle WHERE CobroId = {cobro.CobroId}");
            foreach (var cobroDetalle in cobro.CobrosDetalle)
            {
                contexto.Entry(cobro).State = EntityState.Added;
            }
            try
            {
                contexto.Entry(cobro).State = EntityState.Modified;

                paso = await contexto.SaveChangesAsync() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                await contexto.DisposeAsync();
            }
            return paso;
        }

        public async static Task<bool> Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var cobro = await Buscar(id);

                if (cobro != null)
                {
                    contexto.Cobros.Remove(cobro);
                    paso = await contexto.SaveChangesAsync() > 0;

                    if (paso)
                    {
                        foreach (var cobroDetalle in cobro.CobrosDetalle)
                        {
                            var venta = await VentasBLL.Buscar(cobroDetalle.VentaId);
                            if (venta != null)
                            {
                                venta.Balance += cobroDetalle.Monto;
                                await VentasBLL.Modificar(venta);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await contexto.DisposeAsync();
            }

            return paso;
        }

        public async static Task<Cobros> Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Cobros cobro;

            try
            {
                cobro = await contexto.Cobros
                    .Include(c => c.CobrosDetalle)
                    .Where(v => v.CobroId == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await contexto.DisposeAsync();
            }

            return cobro;
        }


        public async static Task<bool> Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = await contexto.Cobros.AnyAsync(v => v.CobroId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await contexto.DisposeAsync();
            }

            return encontrado;
        }

        public async static Task<List<Cobros>> GetCobros()
        {
            Contexto contexto = new Contexto();

            List<Cobros> cobros = new List<Cobros>();
            await Task.Delay(01); //Para dar tiempo a renderizar el mensaje de carga

            try
            {
                cobros = await contexto.Cobros.Include(c => c.CobrosDetalle).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                await contexto.DisposeAsync();
            }

            return cobros;

        }
    }
}
