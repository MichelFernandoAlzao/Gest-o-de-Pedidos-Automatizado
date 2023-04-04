using Banco_de_Dados;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Relatorios
{
    public class relPedido
    {
        public BDPedido objPedido { get; set; }
        public List<BDItensPedido> objITPedido { get; set; }
        public BDCadastroGeral objCadastroGeral { get; set; }
        string LcaminhoBanco = "";

        public relPedido CarregaRelatorio(string inCaminhoBanco,string inPedido)
        {
            LcaminhoBanco = inCaminhoBanco;
            relPedido objRelPedido = new relPedido();

            BDPedido objPedido = new BDPedido();
            List<BDPedido> lstPedido = objPedido.CarregaDados(LcaminhoBanco, inPedido, "", "");
            if(lstPedido.Count > 0)
            {
                objRelPedido.objPedido = lstPedido[0];
            }
            BDCadastroGeral objCadastro = new BDCadastroGeral();
            List<BDCadastroGeral> lstCadastro = objCadastro.CarregaDados(LcaminhoBanco,objRelPedido.objPedido.cpEmpresaDR,"","","","","","","","","");

            if(lstCadastro.Count > 0)
            {
                objRelPedido.objCadastroGeral = lstCadastro[0];
            }
            
            BDItensPedido objItensPed = new BDItensPedido();
            objItensPed.cpPedidoDR = objRelPedido.objPedido.cpID;
            List<BDItensPedido> lstItensPed = objItensPed.CarregaDados(LcaminhoBanco);

            objRelPedido.objITPedido = lstItensPed;

            return objRelPedido;
        }
    }
}