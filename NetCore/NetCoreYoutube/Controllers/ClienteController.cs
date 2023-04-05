using Microsoft.AspNetCore.Mvc;
using NetCoreYoutube.Models;

namespace NetCoreYoutube.Controllers
{

    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente()
        {
            List<Cliente> clientes = new List<Cliente>
            { 
                new Cliente
                {
                    id= "1",
                    correo="google@gmail.com",
                    edad="19",
                    nombre="Bernardo Peña"
                },
                new Cliente
                {
                    id= "2",
                    correo="miguelgoogle@gmail.com",
                    edad="23",
                    nombre="Miguel Mantilla"
                }
            };
            return clientes;
        }
        [HttpGet]
        [Route("listarxid")]
        public dynamic listarClientexid(int codigo)
        {
            //obtienes el cliente de la db
            return new Cliente
            {
                id = codigo.ToString(),
                correo = "google@gmail.com",
                edad = "19",
                nombre = "Bernardo Peña"
            };
        }
        [HttpPost]
        [Route("guardar")]
        public dynamic guardarCliente(Cliente cliente)
        {
            //Guardar en la db
            cliente.id = "3";
            return new
            {
                success = true,
                message= "cliente registrado",
                results = cliente
            };
        }

        [HttpPost]
        [Route("eliminar")]
        public dynamic eliminarCliente(Cliente cliente)
        {
            string token = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;
            //Se elimina el cliente en la db

            if(token != "marco123.")
            {
                return new
                {
                    success = false,
                    message = "token incorrecto",
                    result = "null"
                };
            }
            return new
            {
                success = true,
                message ="Cliente eliminado",
                result = cliente
            };
        }
    }
}
