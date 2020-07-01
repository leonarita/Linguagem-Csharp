using Loja.DAL;
using Loja.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.BLL
{
    public class UsuarioBLL
    {
        /*Método cargaUsuario, retorna uma Lista de objetos usuario DTO (composto por vários atributos), vai até o BD e buscar todos os usuários. 
         * Usamos o try e Catch caso de algum erro, retorna para a camada view Executar o método cargaUsuario (será criado na DAL) */
        public IList<UsuarioDTO> cargaUsuario() 
        { 
            try 
            { 
                return new UsuarioDAL().cargaUsuario(); 
            } 
            catch (Exception ex) 
            { 
                throw ex; 
            } 
        }

        public int insereUsuario(UsuarioDTO USU)
        {
            /*Insere usuario será criado na DAL*/
            try
            {
                return new UsuarioDAL().insereUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int alteraUsuario(UsuarioDTO USU)
        {
            try
            {
                return new UsuarioDAL().alteraUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int excluiUsuario(UsuarioDTO USU)
        {
            try
            {
                return new UsuarioDAL().excluiUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
