using Camada_Relatorios;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco_de_Dados;
using System.Reflection;

namespace CarregaRelatorios
{
    public class RelRegistroContatos
    {
        public string OPRegContatosEmpresa { get; set; }
        public string CDCERazaoSocial { get; set; }
        public string OPRCEDataContato { get; set; }
        public string OPRCESugestao { get; set; }
        public string USUsuario { get; set; }

        public List<RegistrodeContato> CarregaRelatorioRDLC(string inCaminhoBanco, string[] inParametrosRel)
        {
            string inVendedor = inParametrosRel[1];
            string inDataInicial = inParametrosRel[2];
            string inDataFinal = inParametrosRel[3];
            string inEmpresa  = inParametrosRel[4];
            DataTable DTRegistrosDeContatos = new DataTable();
            string sSQL = "";
            sSQL += "select OPRegContatosEmpresa, CDCERazaoSocial, OPRCEDataContato, OPRCERegistro, USUsuario ";
            sSQL += "from OPRegContatosEmpresa ";
            sSQL += "INNER JOIN CDCadastroEmpresas ON OPRCEEmpresaDR = CDCadastroEmpresas ";
            sSQL += "INNER JOIN SEGUsuarios ON OPRCEusuarioDR = SEGUsuarios ";
            sSQL += "where(OPRCEDataContato >= '" + inDataInicial + "' AND OPRCEDataContato <= '" + inDataFinal + "')";
            if (inVendedor != "")
            {
                sSQL += " AND OPRCEusuarioDR = '" + inVendedor + "'";
            }
            if(inEmpresa != "")
            {
                sSQL += " AND OPRCEEmpresaDR = '" + inEmpresa + "'";
            }
            sSQL += " order by OPRCEDataContato desc, USUsuario";


            Conexao conexao = new Conexao(inCaminhoBanco);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sSQL;

            List<RegistrodeContato> lstregistrodeContatos = new List<RegistrodeContato>();

            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                SqlDataReader reader = cmd.ExecuteReader();
                DTRegistrosDeContatos.Load(reader);
                reader.Close();


                foreach (DataRow dr in DTRegistrosDeContatos.Rows)
                {
                    RegistrodeContato bDRegistrodeContatos = new RegistrodeContato();
                    bDRegistrodeContatos.OPRegContatosEmpresa = dr["OPRegContatosEmpresa"].ToString();
                    bDRegistrodeContatos.CDCERazaoSocial = dr["CDCERazaoSocial"].ToString();
                    bDRegistrodeContatos.OPRCEDataContato = dr["OPRCEDataContato"].ToString();
                    bDRegistrodeContatos.OPRCESugestao = dr["OPRCERegistro"].ToString();
                    bDRegistrodeContatos.USUsuario = dr["USUsuario"].ToString();


                    lstregistrodeContatos.Add(bDRegistrodeContatos);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {

            }
            cmd.Dispose();
            return lstregistrodeContatos;
        }
    }
}

