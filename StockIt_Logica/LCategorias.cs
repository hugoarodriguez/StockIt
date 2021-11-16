using StockIt_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Logica
{
    public class LCategorias
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public int InsertarCategoria(int idUsuario,  ECategoria eCategoria)
        {
            try
            {
                return WS.insertarCategoria(idUsuario, eCategoria.Categoria);
            }
            catch (Exception)
            {
                return -3;
            }
        }

        public int ActualizarCategoria(int idUsuario, ECategoria eCategoria)
        {
            try
            {
                return WS.actualizarCategoria(idUsuario, eCategoria.IdCategoria, eCategoria.Categoria);
            }
            catch (Exception)
            {
                return -3;
            }
        }

        public int EliminarCategoria(ECategoria eCategoria)
        {
            try
            {
                return WS.eliminarCategoria(eCategoria.IdCategoria);
            }
            catch (Exception)
            {
                return -3;
            }
        }

        public List<ECategoria> SeleccionarCategoriasByIdUsuario(int idUsuario)
        {
            List<ECategoria> lista = new List<ECategoria>();
            try
            {
                DataSet ds = WS.seleccionarCategoriasByIdUsuario(idUsuario);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ECategoria eCategoria = new ECategoria();
                    eCategoria.IdCategoria = int.Parse(row["ID_CATEGORIA"].ToString());
                    eCategoria.IdUsuario = int.Parse(row["ID_USUARIO"].ToString());
                    eCategoria.Categoria = row["CATEGORIA"].ToString();
                    eCategoria.EstadoCategoria = row["ESTADO_CATEGORIA"].ToString() == "A" ? "ACTIVA" : "INACTIVA";
                    lista.Add(eCategoria);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public List<ECategoria> SeleccionarCategoriasActivasByIdUsuario(int idUsuario)
        {
            List<ECategoria> lista = new List<ECategoria>();
            try
            {
                DataSet ds = WS.seleccionarCategoriasActivasByIdUsuario(idUsuario);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ECategoria eCategoria = new ECategoria();
                    eCategoria.IdCategoria = int.Parse(row["ID_CATEGORIA"].ToString());
                    eCategoria.IdUsuario = int.Parse(row["ID_USUARIO"].ToString());
                    eCategoria.Categoria = row["CATEGORIA"].ToString();
                    eCategoria.EstadoCategoria = "ACTIVA";
                    lista.Add(eCategoria);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public DataTable SeleccionarCategoriasActivasByIdUsuarioDT(int idUsuario)
        {
            DataTable dt = new DataTable();
            try
            {
                DataSet ds = WS.seleccionarCategoriasActivasByIdUsuario(idUsuario);

                return ds.Tables[0];
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataTable SeleccionarCategoriasActivasByIdUsuarioAndFechasForReporte(int idUsuario, DateTime fechaInicio, DateTime fechaFinal)
        {
            try
            {
                DataSet ds = WS.seleccionarCategoriasActivasByIdUsuarioAndFechasForReporte(idUsuario, fechaInicio, fechaFinal);

                return ds.Tables[0];
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }
    }
}
