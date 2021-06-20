using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projeto_inserir
    {
    public partial class remover : System.Web.UI.Page
        {
        protected void Page_Load(object sender, EventArgs e)
            {
            if (CapturaID())
                {
                DadosConsulta();
                }

            }
        private bool CapturaID()
            {
            return Request.QueryString.AllKeys.Contains("id");
            }
        private void DadosConsulta()
            {

            int IDUsuario = ObterIDUsuario();
            try
                { 

                
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"select * from usuario
                                    where id_us = @IDUsuario";

                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);

                Conexao.Conectar();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    {

                    txtNome.Text = reader["nome_us"].ToString();
                    txtLogin.Text = reader["login_us"].ToString();
                    
                    ddlNivel.Text = reader["nivel_us"].ToString();
                    }

                }
            
            catch (Exception ex)
                {

                throw;
                }
            finally
                {
                Conexao.Desconectar();
                }
            }
        private int ObterIDUsuario()
            {
            int id = 0;
            var idURL = Request.QueryString["id"];
            if (!int.TryParse(idURL, out id))
                {
                throw new Exception("ID Inválido");
                }
            if (id <= 0)
                {
                throw new Exception("ID Inválido");
                }
            return id;
            }

        protected void btnDeletar_Click(object sender, EventArgs e)
            {

            int IDUsuario = ObterIDUsuario();
            try
                {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"delete from usuario
                                    where id_us = @IDUsuario";

                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);

                Conexao.Conectar();
                cmd.ExecuteNonQuery();

                }
            catch (Exception ex)
                {
                   throw;
                }
            finally
                {
                Conexao.Desconectar();
                }


            }

        protected void btnVoltar_Click(object sender, EventArgs e)
            {
              Response.Redirect("Listar.aspx");
            }
        }
    }