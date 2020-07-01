using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PitangaBrasil
{

    public partial class tlMenuInicial : Form
    {
        public tlMenuInicial()
        {
            InitializeComponent();

            //Reseta todas as variáveis globais
            Global.gbNickname = "";
            Global.gbCaixa = 0x00;
            Global.gbImagem = 0x00;
            Global.gbContadorCaso = 0x00;
            Global.gbIndexTema = 0x00;
            Global.gbRespostaCaso = "";
            Global.gbExportacao = 0x00;
            Global.gbImportacao = 0x00;
            Global.gbFinanceiro = 0x00;
            Global.gbJuridico = 0x00;
            Global.gbMarketing = 0x00;
            Global.gbRecursosHumanos = 0x00;

            Global.gbPerguntaBasica = new List<string> {
                    "Quais são os documentos obrigatórios para a exportação?",
                    "Quais são os documentos obrigatórios para a importação?",
                    "Qual alternativa representa as taxas de origem na Exportação?",
                    "Qual regime aduaneiro permite o fretamento da carga?",
                    "Qual canal representa as conferências físicas e documentos?",
                    "Em qual cidade está localizada o maior porto do mundo?",
                    "Qual é o número total de portos no Brasil?",
                    "Em qual Incoterm a responsabilidade do vendedor vai até a entrega?",
                    "Onde se localizar a Zona Franca brasileira?",
                    "Pessoas físicas podem exportar?",
                    "Qual a base de cálculo do Imposto de Importação?",
                    "Para exportação direta a empresa deve se registrar em qual órgão?",
                    "Quais são os registros necessários para empresa importar e exportar?",
                    "Qual a base de cálculo do ICMS?",
                    "Quais são os principais custos que envolvem uma exportação?",
                    "Qual meio de pagamento não oferece risco ao exportador?",
                    "Qual imposto pode ser creditado conforme o valor de entrada da mercadoria?",
                    "Qual o conceito de Drawback?",
                    "Qual documento é exigido para alguns produtos dependendo do NCM?",
                    "O que é o NCM?",
                    "Quais são as cores utilizadas para parametrização do Despacho Aduaneiro na Importação?",
                    "O que são os Incoterms?",
                    "Quais são os conhecimentos de embarque para o modal aéreo?",
                    "Qual é o conhecimento de embarque para o modal marítimo?",
                    "Quais são os conhecimentos de embarque para o modal terrestre?",
                    "Qual é o órgão que regula o comércio internacional no mundo?",
                    "Quais os órgãos que regulam o comércio internacional no Brasil?",
                    "O que são os Regimes Aduaneiros Especiais?",
                    "Assinale a alternativa que não representa um INCOTERM:",
                    "Qual é o decreto que regula o comércio internacional brasileiro?",
                    "Quais das alternativas não representam um acordo comercial:",
                    "O que é a ALCA?",
                    "O que é o SISCOMEX?",
                    "Qual órgão é responsável pela regulação do SISCOMEX?",
                    "Qual desses países não é associado ao MERCOSUL?",
                    "Qual desses países não faz parte da União Europeia?",
                    "Qual é o modal mais utilizado para transportar mercadorias intercontinentais?",
                    "Quais são os principais Ricos da Internacionalização?",
                    "Qual é o nome do Acordo Comercial entre México, Estados Unidos e Canadá?",
                    "Quais países fazem parte do BRICS?",
                    "Qual país recentemente deixou a União Européia?",
                    "Qual o primeiro passo para adentrar no mercado externo?",
                    "Qual é a moeda mais utilizada mundialmente em negociações internacionais?",
                    "Qual é a moeda mais cara do mercado internacional?",
                    "Qual a bolsa de valores mais cara do mundo?",
                    "Qual país da América Latina, possui mais acordos comerciais? ",
                    "Quantos países compõem a União Europeia?",
                    "Qual a empresa de transportes mais rápida do mundo? ",
                    "Qual a moeda local dos Emirados Árabes Unidos?",
                    "Quem são as 3 maiores potências mundiais?"};
            //Vetor que armazena as alternativas "A" das Perguntas Básicas
            Global.gbAlternativaA = new List<string> {
                "Profoma Invoice, Invoice, Letter of Credit, Packing List, DI e CI",
                "Proforma Invoice, Invoice, Packing List, Conhecimento de Embarque, DI e CI",
                "THC, Bl Free, Gate, ISPS, Seal, Foodgrade, Transmission Free e VGM",
                "Entreposto Aduaneiro",
                "Cinza",
                "Nova Orleans",
                "100",
                "EXW",
                "Santos",
                "Sim, desde que em pouca quantidade",
                "Valor da mercadoria",
                "Siscomex",
                "SISCOMEX, Receita Federal e REI",
                "(Valor Aduaneiro + II + IPI + PIS + COFINS + Taxa Siscomex)/(1-Alíquota)",
                "Produto, despachante, seguro e transporte",
                "Pagamento antecipado",
                "IPI",
                "Uma documentação",
                "Packing List",
                "Nomenclatura de Código de Mercado",
                "Verde, Amarelo, Roxo, Cinza",
                "É o conjunto de impostos obrigatórios para a transição de mercadorias entre países " +
                "publicados pela Câmara Internacional de Comércio",
                "BL e CTF",
                "BL",
                "CTR e CTF",
                "ONU",
                "CAMEX, SISCOMEX, MDIC",
                "Regimes que permitem a circulação livre de mercadoria",
                "AWB",
                "Regulamento do Comex",
                "ALADI",
                "Área de Livre acesso ao Comércio Americano",
                "Sistema de Comércio Exterior Brasileiro",
                "MDIC",
                "Chile",
                "Áustria",
                "Aéreo",
                "Intercultural, Político, Ambiental, Cambial",
                "ALCA",
                "Brasil, Rússia, Índia, China e África do Sul. ",
                "França",
                "Importação direta",
                "Euro",
                "Dólar Australiano",
                "NYSE",
                "Peru",
                "27",
                "Hyperloop",
                "Dólar Arabé",
                "França, China, Rússia"};
            //Vetor que armazena as alternativas "B" das Perguntas Básicas
            Global.gbAlternativaB = new List<string> {
                "Proforma Invoice, Invoice, Packing List, Certificado de Origem, Conhecimento de Embarque e CE",
                "Invoice, Packing List, Conhecimento de Embarque, DI e CI",
                "THC, Bl Free, Gate, ISPS, Seal, Foodgrade, Transmission Free e AFRMM",
                "Admissão Temporária",
                "Vermelho",
                "Shangai",
                "150",
                "FOB",
                "Manaus",
                "Não",
                "Valor da mercadoria + Frete + Seguro + THC",
                "Receita Federal",
                "SISCOMEX, Trade e REI",
                "(Valor Aduaneiro + II + IPI + PIS + Taxa Siscomex)/(1-Alíquota)",
                "Produto, porto, seguro",
                "Carta de crédito",
                "ICMS",
                "Um regime aduaneiro especial",
                "Certificado de Origem",
                "Nomenclatura Comum do Mercosul",
                "Verde, Amarelo, Vermelho, Preto",
                "São os termos de vendas internacionais publicados pela Câmara Internacional de Comércio",
                "AWB, MAWB e HAWB",
                "CTR",
                "AWB, MAWB e HAWB",
                "OMC",
                "MDIC, COMEX VIS, CAMEX",
                "Regimes que permitem benefícios tributários para as empresas",
                "DDP",
                "Regulamento do Comércio Exterior",
                "MERCOSUL ",
                "Área de Livre Comércio das América",
                "Sistema Integrado de Comércio Exterior",
                "CAMEX",
                "Colômbia",
                "Holanda",
                "Ferroviário",
                "Político, Ambiental, Intercultural e Comercial",
                "MERCOSUL",
                "Bélgica, República Tcheca, Israel, Costa rica e Servia. ",
                "Grécia",
                "Importação para um terceiro",
                "Dólar Canadense",
                "Libra Esterlina",
                "NASDAQ",
                "Argentina",
                "32",
                "Fedex",
                "Dirrã",
                "Estados Unidos, China, Rússia"};
            //Vetor que armazena as alternativas "C" das Perguntas Básicas
            Global.gbAlternativaC = new List<string> {
                    "Invoice, Packing List, Conhecimento de Embarque, DI  e CI",
                    "Profroma Invoice, Invoice, Letter of Credit, Packing List, DI, CI",
                    "THC, Bl Free, Gate, ISPS, Seal, ICMS, Transmission Free e VGM",
                    "Trânsito Aduaneiro",
                    "Amarelo",
                    "Singapura",
                    "175",
                    "CIF",
                    "Paranaguá",
                    "Sim, sem nenhuma restrição",
                    "Valor da mercadoria + Frete + Seguro",
                    "Aduaneira",
                    "SISCOMEX, RADAR E REI",
                    "Valor Aduaneiro + II + IPI + PIS + COFINS + Taxa Siscomex",
                    "Transporte, despachante e seguro",
                    "Cobrança documentária",
                    "PIS",
                    "Um tipo de tributo",
                    "Licenciamento",
                    "Nomenclatura com o Mercosul",
                    "Amarelo, Verde, Vermelho, Cinza",
                    "São os termos que indicam em qual moeda a transação deve ser executada publicada pela Câmara Internacional" +
                    " do Comércio",
                    "TIF e CTF",
                    "AWB",
                    "TIF, CTF e CTR",
                    "ONC",
                    "MDIC, RFB, CAMEX",
                    "Regimes que definem quem será o responsável pelo transporte da mercadoria",
                    "CPT",
                    "Regulamento Aduaneiro",
                    "CAMEX",
                    "Área de Livre Comércio da América Latina",
                    "Sistema de Comércio Exterior",
                    "COMEX VIS",
                    "Uruguai ",
                    "Suíça",
                    "Marítimo",
                    "Cambial, Comercial, Intercultural e Político",
                    "NAFTA",
                    "Bolívia, Romênia, Inglaterra, Canadá e Samoa. ",
                    "Inglaterra",
                    "Planejamento estratégico ",
                    "Dólar Americano",
                    "Franco Suíço",
                    "Tokyo Stock",
                    "Brasil",
                    "40",
                    "Amazon",
                    "Rupia",
                    "Coréia do Sul, Índia, Reino Unido"};
            Global.gbResposta = new List<int> {2, 1, 1, 1, 2, 2, 3, 1, 2, 1, 2, 1, 3, 1, 1, 1, 2, 2, 3, 2, 3, 2, 2, 1, 3, 2,
                    2, 2, 1, 3, 3, 2, 2, 1, 3, 3, 3, 3, 3, 1, 3, 3, 3, 2, 1, 3, 1, 1, 2, 2};
        }

        private void BtJogar_Click(object sender, EventArgs e)
        {
            //Avança para a tela Introdução
            tlIntrodução Tela_Introdução = new tlIntrodução();
            Tela_Introdução.ShowDialog();
            Close();
        }


        private void BtRanking_Click(object sender, EventArgs e)
        {
            //Avança para a tela Ranking
            tlRanking Tela_Ranking = new tlRanking();
            Tela_Ranking.ShowDialog();
            Close();
        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            var lcFechar = MessageBox.Show("Tem certeza que deseja sair?", "Fechar Jogo", MessageBoxButtons.YesNo);
            if (lcFechar == DialogResult.Yes)
                Close();
        }
    }
}
