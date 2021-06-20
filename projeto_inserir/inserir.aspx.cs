using MySqlConnector;
using System;

namespace projeto_inserir
    {
    public partial class inserir : System.Web.UI.Page
        {
        protected void Page_Load(object sender, EventArgs e)
            {

            }

        protected void btnSalvar_Click(object sender, EventArgs e)
            {

            //Bcrypt
            var senhaEncriptada = BCrypt.Net.BCrypt.HashPassword(txtSenha.Text);

            MySqlCommand cmd = new MySqlCommand();
            try
                {
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"insert into usuario
                                    (nome_us, login_us, senha_us,
                                    nivel_us)
                                    values
                                    (@nome_us, @login_us, @senha_us, @nivel_us)";

                cmd.Parameters.AddWithValue("@nome_us", txtNome.Text);
                cmd.Parameters.AddWithValue("@login_us", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha_us", senhaEncriptada);
                cmd.Parameters.AddWithValue("@nivel_us", ddlNivel.Text);

                

                Conexao.Conectar();
                cmd.ExecuteNonQuery();
                Response.Redirect("editar.aspx");

                }
            catch (Exception ex)
                { 
                lblResultado.CssClass = "text text-danger";
                lblResultado.Text = $"Error: {ex.Message}";
                }
            finally
                {
                Conexao.Desconectar();
                }
            }
        }
 }