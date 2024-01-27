using ApiLavanderia.Datos;
using ApiLavanderia.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace ApiLavanderia.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class LUsuariosController:ControllerBase
    {
        [HttpGet]

        public async Task<ActionResult<List<MLUsuarios>>> Get()
        {
            var usuario = new DLUsuarios();
            var Listausuarios = await usuario.Obtenerusuarios();
            return Listausuarios;
        }

        [HttpPost]
        public async Task Post([FromBody] MLUsuarios parametros)
        {
            var funcion = new DLUsuarios();
            await funcion.AgregarUsuarios(parametros);
        }

        [HttpPut("{keyUser}")]
        public async Task <ActionResult> Put(int keyUser, [FromBody] MLUsuarios parametros)
        {
            var funcion = new DLUsuarios();
            parametros.KeyUser = keyUser;
            await funcion.EditarUsuarios(parametros);
            return NoContent(); 
        }

        [HttpDelete("{kuser}")]

        public async Task<ActionResult> Delete(int kuser)
        {
            var funcion = new DLUsuarios();
            var parametros = new MLUsuarios();
            parametros.KeyUser = kuser;
            await funcion.EliminarUsuarios(parametros);
            return NoContent();
        }

    }
}
