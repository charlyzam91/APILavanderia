using ApiLavanderia.DAO;
using ApiLavanderia.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace ApiLavanderia.Datos
{
    public class DLUsuarios
    {
        ConexionBD cn = new ConexionBD();

        public async Task<List<MLUsuarios>> Obtenerusuarios()
        {
            var ListaUsuarios = new List<MLUsuarios>();
            using (var sql = new SqlConnection(cn.LinkBD()))
            {
                using (var cmd = new  SqlCommand("SpObtenerUsuariosSistema", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while(await item.ReadAsync())
                        {
                                var Lusuario = new MLUsuarios();
                            Lusuario.KeyUser = (int)item["key_usuario"];
                            Lusuario.Nick = (string)item["Nick"];
                            Lusuario.Secreto= (string)item["secreto"];
                            Lusuario.FechaRegistro = (DateTime)item["Fecha_Registro"];
                            Lusuario.activo = (Boolean)item["Activo"];
                            ListaUsuarios.Add(Lusuario);
                         }
                    }
                }
            }
            return ListaUsuarios;
        }

        public async Task AgregarUsuarios(MLUsuarios parametros)

        {
            using (var sql = new SqlConnection(cn.LinkBD()))
            {
                using(var cmd = new SqlCommand("SPAgregaUsuarios", sql))
                {
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario", parametros.Nick);
                    cmd.Parameters.AddWithValue("@pssw", parametros.Secreto);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();  
                }
            }
        }

        public async Task EditarUsuarios(MLUsuarios parametros)

        {
            using (var sql = new SqlConnection(cn.LinkBD()))
            {
                using (var cmd = new SqlCommand("SPEditarSecretoUsuarios", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@KeyUsuario", parametros.KeyUser );
                    cmd.Parameters.AddWithValue("@pssw", parametros.Secreto);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task EliminarUsuarios(MLUsuarios parametros)

        {
            using (var sql = new SqlConnection(cn.LinkBD()))
            {
                using (var cmd = new SqlCommand("SPEliminarUsuarios", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@KeyUsuario", parametros.KeyUser);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
