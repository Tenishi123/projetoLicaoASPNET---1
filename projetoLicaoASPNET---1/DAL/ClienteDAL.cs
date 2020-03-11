using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace projetoLicaoASPNET___1.DAL
{
    public class ClienteDAL
    {

        Conexao conexao = new Conexao();

        public void cadastrar(BLL.Cliente cliente)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao.conectar();
            sqlCommand.CommandText = @"INSERT INTO CLIENTE(NOME,CPF,EMAIL,ENDERECO)VALUES(@NOME,@CPF,@EMAIL,@ENDERECO);";
            sqlCommand.Parameters.AddWithValue("@NOME", cliente.Nome);
            sqlCommand.Parameters.AddWithValue("@CPF", cliente.Cpf);
            sqlCommand.Parameters.AddWithValue("@EMAIL", cliente.Email);
            sqlCommand.Parameters.AddWithValue("@ENDERECO", cliente.Endereco);
            sqlCommand.ExecuteNonQuery();

            conexao.disconectar();

        }

        public void excluir(BLL.Cliente cliente)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao.conectar();
            sqlCommand.CommandText = @"DELETE CLIENTE WHERE CODCLIENTE = @CODCLIENTE;";
            sqlCommand.Parameters.AddWithValue("@CODCLIENTE", cliente.CodUsuario);
            sqlCommand.ExecuteNonQuery();

            conexao.disconectar();

        }

        public void update(BLL.Cliente cliente)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao.conectar();
            sqlCommand.CommandText = @"UPDATE CLIENTE SET NOME = @NOME, EMAIL = @EMAIL, CPF = @CPF, ENDERECO = @ENDERECO WHERE CODUSUARIO = @CODUSUARIO;";
            sqlCommand.Parameters.AddWithValue("@CODUSUARIO", cliente.CodUsuario);
            sqlCommand.Parameters.AddWithValue("@NOME", cliente.Nome);
            sqlCommand.Parameters.AddWithValue("@CPF", cliente.Cpf);
            sqlCommand.Parameters.AddWithValue("@EMAIL", cliente.Email);
            sqlCommand.Parameters.AddWithValue("@ENDERECO", cliente.Endereco);

            sqlCommand.ExecuteNonQuery();

            conexao.disconectar();

        }

        public DataTable select(BLL.Cliente cliente)
        {

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao.conectar();
            sqlCommand.CommandText = @"SELECT CODCLIENTE,NOME,CPF,EMAIL,ENDERECO FROM CLIENTE WHERE NOME LIKE @NOME;";
            sqlCommand.Parameters.AddWithValue("@NOME", "%" + cliente.Nome + "%");
            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            conexao.disconectar();

            return dataTable;

        }

        public DataTable select()
        {

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao.conectar();
            sqlCommand.CommandText = @"SELECT CODCLIENTE,NOME,CPF,EMAIL,ENDERECO FROM CLIENTE;";
            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            conexao.disconectar();

            return dataTable;

        }

    }
}