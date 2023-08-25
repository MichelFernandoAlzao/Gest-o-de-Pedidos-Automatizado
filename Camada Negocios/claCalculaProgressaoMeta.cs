using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco_de_Dados;

namespace Camada_Negocios
{
    public class claCalculaProgressaoMeta
    {
        string LCaminhoBanco;
        string[] lstValores;
        string LUsuario;
        double LMeta = 0.00;
        double LSomaPedidos = 0.00;
        int LPercProgressao;
        double LobjDiario = 0.00;
        public string[] CarregaProgressao(string inCmainhoBanco,string inUsuario)
        {
            LCaminhoBanco = inCmainhoBanco;
            LUsuario = inUsuario;
            //lstValores[0] = Meta vinda dos parametros
            //lstValores[1] = Valor progredido da meta
            //lstValores[2] = Valor não Consolidado
            //lstValores[3] = Objetivo Diario
            SEGUsuario objUsuario = new SEGUsuario();
            List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco,inUsuario,"","","");
            if(lstUsuario.Count > 0)
            {
                if (lstUsuario[0].Meta != "")
                {
                   LMeta = Convert.ToDouble(lstUsuario[0].Meta.ToString());
                }                
            }
            else
            {
                LMeta = 0;
            }

            CalculaPrograssaoMeta();
            //Calcula percentual da meta
            if(LSomaPedidos < LMeta)
            {
                LPercProgressao = Convert.ToInt32((LSomaPedidos / LMeta) * 100);
            }
            else
            {
                if(LMeta == 0)
                {
                    LPercProgressao = 0;
                }
                else
                {
                    LPercProgressao = 100;
                }
                
            }
            

            CalculaObjetivoDiario();

            string[] valores = new string[]
            {
                LMeta.ToString(),
                LPercProgressao.ToString(),
                LSomaPedidos.ToString(),
                LobjDiario.ToString()

            };

            lstValores = valores;
            return lstValores;
        }


        public void CalculaPrograssaoMeta()
        {
            //Vamos considerar que a data seja o dia de hoje, mas pode ser qualquer data.
            DateTime data = DateTime.Today;
            //DateTime com o primeiro dia do mês
            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);
            //DateTime com o último dia do mês
            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            //Variavel que ira receber a soma dos pedidos
            
            BDPedido objPedidos = new BDPedido();
            List<BDPedido> lstPedido = objPedidos.CarregaDadosData(LCaminhoBanco,Convert.ToString(primeiroDiaDoMes),Convert.ToString(ultimoDiaDoMes),LUsuario,"Concluido","","");
            if(lstPedido.Count > 0)
            {
                foreach(BDPedido item in lstPedido)
                {
                    if(item.cpVlrItensFaturando == "" || item.cpVlrItensFaturando == null)
                    {
                        continue;
                    }
                    LSomaPedidos = LSomaPedidos + Convert.ToDouble(item.cpVlrItensFaturando);
                }
            }
            else
            {
                LSomaPedidos = 0;
            }
        }

        public void CalculaObjetivoDiario()
        {
            //Vamos considerar que a data seja o dia de hoje, mas pode ser qualquer data.
            DateTime data = DateTime.Today;
            //DateTime com o primeiro dia do mês
            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);
            //DateTime com o último dia do mês
            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
            if(LSomaPedidos < LMeta)
            {
                LobjDiario = (LMeta - LSomaPedidos) / (ultimoDiaDoMes.Day - DateTime.Today.Day);
            }
            else
            {
                LobjDiario = 0.00;
            }
            

        }
    }
}
