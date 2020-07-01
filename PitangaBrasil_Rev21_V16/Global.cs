using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PitangaBrasil
{
    //Classe com todas as variáveis globais da aplicação
    class Global
    {
        public static int
                gbExportacao = 0x00, //Variável de status do botão Exportação                   - Tela Materias
                gbImportacao = 0x00, //Variável de status do botão Importação                   - Tela Materias
                gbFinanceiro = 0x00, //Variável de status do botão Financeiro                   - Tela Materias
                gbJuridico = 0x00, //Variável de status do botão Jurídico                       - Tela Materias
                gbMarketing = 0x00, //Variável de status do botão Marketing                     - Tela Materias
                gbRecursosHumanos = 0x00, //Variável de status do botão Recursos Humanos        - Tela Materias
                gbCaixa = 0x00, //Variável para armazenar dinheiro durante partida              - Múltiplas telas
                gbImagem = 0x00, //Variável para armazenar pontuação durante partida            - Múltiplas telas
                gbContadorBasica = 0x00, //Variável para contar quantia de perguntas realizadas - Tela Perguntas Básicas
                gbContadorCaso = 0x00, //Variável para contar quantia de perguntas realizadas   - Telas Perguntas Caso
                gbIndexTema = 0x00; //Variável para armazenar o tema sendo jogado               - Telas Materias/Caso

        public static List<int>
                //Vetor que armazena as posições das respostas corretas para as Perguntas Básicas
                gbResposta = new List<int> {2, 1, 1, 1, 2, 2, 3, 1, 2, 1, 2, 1, 3, 1, 1, 1, 2, 2, 3, 2, 3, 2, 2, 1, 3, 2,
                    2, 2, 1, 3, 3, 2, 2, 1, 3, 3, 3, 3, 3, 1, 3, 3, 3, 2, 1, 3, 1, 1, 2, 2},
                //Vetor que armazena o dinheiro das repostas das alternativas "A" das Perguntas Caso
                gbDinheiro1 = new List<int> {3000, 10000, -8000, 2000, -7500, 10000, -800, -16707, 24960, 25000, -3000,
                    -1000, 12000, -8000, -8000, -2000, -5000, -5000},
                //Vetor que armazena o dinheiro das repostas das alternativas "B" das Perguntas Caso
                gbDinheiro2 = new List<int> {0, -5000, -7000, 0, 4000, -1000, 38000, -18713, 26520, 31000, -45000, -1000,
                    9000, -2000, -2000, -2000, -5000, -8000},
                //Vetor que armazena o dinheiro das repostas das alternativas "C" das Perguntas Caso
                gbDinheiro3 = new List<int> {4000,2000,5000,1000,-1000,7500,-200,-40000,24960,24000,-35000,1000,8000,-5000,
                    -5000, -4000,-4000,-3000},
                //Vetor que armazena o dinheiro das repostas das alternativas "D" das Perguntas Caso
                gbDinheiro4 = new List<int> {-7000, 1000, -5000, -2000, -1000, -1000, 0, -17264, 24440, 24000, 35000, -1000,
                    1000, -6000, -6000, -7000, -5000, -4000},
                //Vetor que armazena a pontuação das repostas das alternativas "A" das Perguntas Caso
                gbImagem1 = new List<int> { -10, 6, -1, 6, 5, 7, -5, 3, 1, -5, 10, -3, 8, 0, 0, 2, 3, 3 },
                //Vetor que armazena a pontuação das repostas das alternativas "B" das Perguntas Caso
                gbImagem2 = new List<int> { 4, -3, 4, -6, 5, 3, 5, -4, 1, 8, -10, -3, -8, 9, 9, 3, -3, 2 },
                //Vetor que armazena a pontuação das repostas das alternativas "C" das Perguntas Caso
                gbImagem3 = new List<int> { -4, 3, 6, -1, 1, 5, -2, 3, 1, -6, -10, 3, -8, -8, -8, -3, 3, 3 },
                //Vetor que armazena a pontuação das repostas das alternativas "D" das Perguntas Caso
                gbImagem4 = new List<int> { -7, 3, -4, -2, 2, 2, -2, 3, 0, -6, -5, -3, -8, -8, -8, -5, 3, 4 },
                //Lista que armazena os valores de caixa												
                gbRankingCaixa = new List<int>(),
                //Lista que armazena os pontos de imagem														
                gbRankingImagem = new List<int>();

        public static List<string>
                //Vetor que armazena o enunciado das Perguntas Básicas
                gbPerguntaBasica = new List<string> {
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
                    "Quem são as 3 maiores potências mundiais?"},
                //Vetor que armazena as alternativas "A" das Perguntas Básicas
                gbAlternativaA = new List<string> {
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
                    "França, China, Rússia"},
                //Vetor que armazena as alternativas "B" das Perguntas Básicas
                gbAlternativaB = new List<string> {
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
                    "Estados Unidos, China, Rússia"},
                //Vetor que armazena as alternativas "C" das Perguntas Básicas
                gbAlternativaC = new List<string> {
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
                    "Coréia do Sul, Índia, Reino Unido"},
                //Vetor que armazena o enunciado das Perguntas Caso
                gbPerguntaCaso = new List<string> {
                    "Questão 1 – A empresa Latex Art demonstrou ser um fornecedor com o preço mais atrativo e insumos ecológicos." +
                    " Mas ao decorrer da negociação foram descobertas multas e certificações vencidas. Neste contexto o que você" +
                    " faria?",
                    "Questão 2 – A Engessada Art apresentou-se para a Pitanga Brasil como um potencial fornecedor mas seu preço é" +
                    " o mais alto do mercado. Qual a melhor maneira de firmar esta parceria?",
                    "Questão 3 – Para escolher um novo parceiro comercial a Pitanga Brasil analisou e considerou dois critérios" +
                    " indispensáveis na tomada de decisão são eles: cadeia de Supply Chain e suas certificações (ISO)." +
                    " Qual a melhor maneira firmar uma parceria?",
                    "Questão 1 – Qual o plano de ação de comunicação mais indicado para obter a consolidação no mercado Colombiano?",
                    "Questão 2 – Pitanga Brasil busca a divulgação de seu portfólio no mercado internacional de maneira eficiente" +
                    " e econômica. Qual a opção mais indicada?",
                    "Questão 3 – Pitanga Brasil busca ampliar e capitar mais Leads para assim elevar também suas oportunidades de" +
                    " vendas futuras. Qual a melhor opção para a empresa?",
                    "Questão 1 – Um cliente do Chile realiza compras mensais e deseja fazer o pagamento 7 dias após a entrega dos" +
                    " produtos no porto de destino. Como você deseja responder a essa negociação?",
                    "Questão 2 – A Pitanga Brasil precisa comprar mais uma máquina para atender a alta demanda de pedidos. Com qual" +
                    " empresa e sob quais perspectivas você fecharia negócio? Dados extras (Câmbio dólar R$ 4.00. A economia" +
                    " brasileira apresenta variação cambial constante).",
                    "Questão 3 – A empresa fechou um grande contrato para exportar 2 mil pares de chinelo para a Califórnia." +
                    " O contrato está negociado em US$ 5.200 e atualmente a cotação do dólar é de R$ 4.80. Porém o mercado" +
                    " brasileiro está apresentando sinais de crise e especialistas estão projetando que a moeda americana irá" +
                    " apreciar nos próximos dias. O que você faria?",
                    "Questão 1 – Com o sucesso na venda de chinelos o cliente precisou fazer um pedido extra de 2000 pares" +
                    " COM URGÊNCIA exigindo a contratação de um seguro no envio do mesmo. Assim qual modal e qual Incoterm" +
                    " são ideais para essa operação?",
                    "Questão 2 – Estamos na época do ano em que o trajeto aéreo para a Colômbia possui grandes variações com" +
                    " tendência à chuva tempestades e nevasca. Para não atrasar os pedidos a Pitanga Brasil precisa dar segmento" +
                    " ao seu processo. Analisando os riscos de avarias é aconselhável:",
                    "Questão 3 – A Pitanga Brasil não pode esquecer que apenas para a contratação de dois Incoterms específicos" +
                    " faz-se obrigatório a contratação do seguro de carga. Quais são eles?",
                    "Questão 1 – Surgiu uma demanda de chinelos de urgência e seu estoque está com previsão para acabar dentro" +
                    " de 15 dias para que o estoque seja reabastecido e você consiga atender a demanda de chinelos que está" +
                    " crescendo o melhor modal para trazer essa remessa de 500 chinelos de urgência é o:",
                    "Questão 2 – A empresa já está fazendo o planejamento para 2021 e devido a crescente nos pedidos de compras de" +
                    " chinelos ela está optando por comprar 5 mil pares para serem vendidos até julho de 2021. O modal mais" +
                    " indicado para essa situação é o:",
                    "Questão 3 – O parceiro comercial da Pitanga Brasil na Colômbia vai inaugurar mais uma loja mas o mesmo" +
                    " solicitou um envio de mercadoria direto para essa nova loja por meio de qual modal será o envio dessa" +
                    " remessa especial?",
                    "Questão 1 – Bem na hora da finalização da emissão do Packing List acabou o horário de expediente. O que" +
                    " você faria?",
                    "Questão 2 – Após as exportações bem-sucedidas a empresa decide fazer uma expatriação. Qual seria o seu" +
                    " primeiro passo?",
                    "Questão 3 – Você precisa de um colaborador que seja fluente em espanhol para que cuide de todos os processos" +
                    " da exportação. Porém não encontrou o perfil desejado no mercado de trabalho. O que você faria?"},
                //Vetor que armazena as alternativas "A" das Perguntas Caso
                gbAlternativaCaso1 = new List<string> {
                    "A) Topa a parceria.",
                    "A) Aceita a precificação proposta.",
                    "A) Desenvolver um fornecedor.",
                    "A) Realizar uma pesquisa de mercado com os consumidores e aguardar 4 meses para finalização do estudo",
                    "A) Propaganda em televisão",
                    "A) Disponibilizar um orçamento elevado para fortalecer o marketing digital da empresa",
                    "A) Negar o faturamento a prazo e correr o risco de perder a venda",
                    "A) ALIDACHINA: Exportação FOB - Custo da máquina US$ 3000.00 + taxas administrativas e portuárias." +
                    "  Pagamento antecipado.",
                    "A) Prefere garantir o valor hoje e fecha o contrato de câmbio.",
                    "A) Modal aéreo com a utilização do Incoterm CIF.",
                    "A) Contratar o seguro garantindo a segurança da carga.",
                    "A) CIP e EXW",
                    "A) Modal aéreo",
                    "A) Modal aéreo",
                    " A) Modal aéreo",
                    "A) Exigiria que o colaborador ficasse até um pouco além do horário para que finalizasse a emissão.",
                    "A) Treinaria o RH para esse processo.",
                    "A) Contrataria um professor particular para ensinar os colaboradores que já são da empresa."},
                //Vetor que armazena as alternativas "B" das Perguntas Caso
                gbAlternativaCaso2 = new List<string> {
                    "B) Nega a parceira.",
                    "B) Nega a precificação e a possível parceria.",
                    "B) Buscar fornecedores apenas nacionais.",
                    "B) Assumir o risco de segmentação inadequada mas lançar imediatamente o produto.",
                    "B) Participação em Feiras de Negócios",
                    "B) Utilizar ferramentas de envio de e-mails publicitários.",
                    "B) Propor receber 50% antecipado e 50% quando o produto for entregue no porto de Santos.",
                    "B) CHINACARGO: Exportação FOB - Custo da máquina US$ 3315.00 + taxas administrativas e portuárias + 30 dias" +
                    " para pagamento.",
                    "B) Decide esperar mais 1 semana para fechar o contrato.",
                    "B) Modal aéreo com a utilização do Incoterm CIP.",
                    "B) Contratar o seguro básico que cobre 50% dos riscos.",
                    "B) FOB e CIF",
                    "B) Modal marítimo",
                    "B) Modal marítimo",
                    "B) Modal marítimo",
                    "B) Deixaria para escolha do colaborador se poderia ou não ficar até mais tarde.",
                    "B) Já expatriaria de cara o Comercial e o Marketing da empresa que serão responsáveis pela Colômbia.",
                    "B) Contrataria um tradutor para auxiliar nos processos"},
                //Vetor que armazena as alternativas "C" das Perguntas Caso
                gbAlternativaCaso3 = new List<string> {
                    "C) Envia os produtos sem uma parceria.",
                    "C) Propõem uma nova proposta.",
                    "C) Negociar apenas com os fornecedores mais conhecidos.",
                    "C) Realizar uma pesquisa parcial e aguardar 2 meses para finalização do estudo",
                    "C) Anúncios em Jornais",
                    "C) Descobrir quais são os principais youtubers da colômbia e presenteá-los com produtos da empresa.",
                    "C) Propor receber 50% antecipado e 25% a vista e faturar 25% para 7 dias.",
                    "C) MAQUINAS BR: Fornecedor Nacional - Custo da máquina R$ 40.000 + 60 dias para pagamento.",
                    "C) Espera mais 2 dias para fechar o contrato.",
                    "C) Modal marítimo com a utilização do Incoterm CIF.",
                    "C) Não contratar o seguro pois o transportador é extremamente confiável.",
                    "C) CIF e CIP",
                    "C) Modal ferroviário",
                    "C) Modal ferroviário",
                    "C) Modal ferroviário",
                    "C) Deixaria para que o documento fosse finalizado no dia seguinte pois a empresa presa pelo bem-estar do" +
                    " colaborador.",
                    "C) Deixaria um colaborador part time no Brasil e part time na Colômbia.",
                    "C) Pagaria uma porcentagem de um curso para um colaborador específico da empresa."},
                //Vetor que armazena as alternativas "D" das Perguntas Caso
                gbAlternativaCaso4 = new List<string> {
                    "D) Negocia os preços e o prazo.",
                    "D) Opta por buscar um novo fornecedor.",
                    "D) Optar por fornecedores pouco conhecidos.",
                    "D) Realizar pesquisa por telefone e aguardar 1 mês para a finalização do estudo.",
                    "D) Midia Out of home (OOH)",
                    "D) Desenvolver um site customizado para os colombianos",
                    "D) Considerando que se trata de um cliente novo propor receber 100% antecipado e não correr nenhum risco" +
                    " de crédito.",
                    "D) LATIN MAQUINAS: Cliente Chileno - Custo da máquina US$ 3100.  Pagamento a vista.",
                    "D) Espera 22 dias para fechar o contrato.",
                    "D) Modal marítimo com a utilização do Incoterm CIP.",
                    "D) Não contratar o seguro pois nunca ocorreu nenhum acidente com as cargas da empresa.",
                    "D) DIP e CFR",
                    "D) Modal rodoviário",
                    "D) Modal rodoviário",
                    "D) Modal rodoviário",
                    "D) Demitiria o colaborador caso ele não aceitasse ficar até mais tarde.",
                    "D) Contrataria um colaborador Colombiano.",
                    "D) Pagaria o curso completo para um colaborador."},
                //Vetor que armazena as consequências das alternativas "A" das Perguntas Caso
                gbConsequencia1 = new List<string> {
                    "Arriscou! Você pressupõe que os consumidores finais não irão pesquisar sobre a empresa parceira e descobrir" +
                    " que ela não é ecológica. Faturou R$ 3000.00 pela parceria. Perdeu 10 Pontos de imagem.",
                    "A Pitanga Brasil propôs uma redução no preço e ofereceu uma margem de visibilidade de parceria." +
                    " Faturou R$ 10000.00. Ganhou 6 pontos de imagem.",
                    "Seria necessário investir financeiramente no fornecedor escolhido propondo um acordo comercial onde seu" +
                    " preço ficaria acessível ao que a empresa busca mas o retorno do investimento seria a longo prazo." +
                    " Investiu R$ 8000.00 e não possui certeza de retorno. Perdeu 1 ponto de imagem.",
                    "A ação de comunicação será especifica e destinada ao consumidor de forma assertiva porém você terá altos" +
                    " custos para elaboração e execução da pesquisa. Investiu R$ 7000.00 e faturou R$ 9000.00. Ganhou 6 pontos de " +
                    "imagem.",
                    "A televisão ainda é classificada como uma inesgotável fonte de alcance publicitário porém possui orçamentos" +
                    " elevados que precisam ser previamente analisados é indicado para empresas de médio a grande porte. " +
                    "Investiu R$ 15000.00 e aumentou o faturamento em R$ 7500.00. Ganhou 5 pontos de imagem.",
                    "A opção é eficiente pois possibilita a capitação de duas fontes de leads qualificados: inbound marketing" +
                    " (marketing de atração) e publicidade segmentada porém possui um custo elevado e é indicado para empresas" +
                    " de médio a grande porte. Investiu R$ 10000.00 porém aumentou o faturamento em R$ 20000.00. Ganhou 7 pontos" +
                    " de imagem.",
                    "A empresa demorou 45 dias para fazer o pagamento e não quis arcar com os juros e multas. Você teve que" +
                    " aceitar e por esse motivo houve um desencaixe no seu fluxo de caixa e teve que pagar juros a outros" +
                    " fornecedores.  Perdeu R$ 800.00. Perdeu 5 pontos de imagem.",
                    "Carga chegou com sucesso. Caixa diminuiu em R$ 16707.00 para pagar o fornecedor. Ganhou 3 pontos de imagem.",
                    "OK! Você decidiu se preservar. O dinheiro da venda estará em seu caixa. Faturou R$ 24960.00. Ganhou 1 ponto" +
                    " de imagem.",
                    "Modal ágil porém o Incoterm da operação está errado. Assim atrasou o envio da carga. Investiu R$ 4000.00 com" +
                    " o frete pagou R$ 6000.00 de multas por atraso porém faturou R$ 35000.00 com a venda. Perdeu 5 pontos" +
                    " de imagem.",
                    "O seguro foi contratado e não ocorreu acidente com a carga. Investiu R$ 3000.00 no pagamento do seguro da" +
                    " carga. Ganhou 10 pontos de imagem.",
                    "Para a utilização do Incoterm CIP (Carriage and Insurance) é obrigatório a contratação do seguro. Porém" +
                    " para a utilização do Incoterm EXW a contratação é facultativa. Perdeu R$ 1000.00 pela falta de informação." +
                    " Perdeu 3 pontos de imagem.",
                    "Embora seja o mais caro também é o que atende com maior rapidez a entrega de um produto. Como nesse caso" +
                    " você está mais preocupado em atender o prazo junto ao consumidor final do que encontrar o melhor" +
                    " custo x benefício esse é o modal mais indicado para essa operação. Investiu R$ 3000.00 porém faturou" +
                    " R$ 15000.00 com a venda. Ganhou 8 pontos de imagem.",
                    "O modal aéreo é indicado para mercadorias que precisam ser entregues dentro de um curto prazo e em menor" +
                    " quantidade além do alto custo do frete que torna inviável essa transação. Investiu R$ 8000.00. Não perdeu" +
                    " pontos de imagem.",
                    "Ao escolher esse modal a mercadoria chegará em um prazo rápido para o cliente no entanto o investimento" +
                    " financeiro para o envio dessa mercadoria será muito alto. Investiu R$ 8000.00. Não perdeu pontos de imagem.",
                    "A empresa conseguiu o prazo correto mas teve um custo extra. Investiu R$ 2000.00 mas atendeu o cliente no" +
                    " prazo correto. Ganhou 2 pontos de imagem.",
                    "Há o custo para treinamento e desenvolvimento do RH da empresa mas com o aprendizado o RH elaborou um" +
                    " checklist com todos os detalhes do processo. Investiu R$ 5000.00. Ganhou 3 pontos de imagem.",
                    "A contratação do professor foi um investimento caro porém trouxe flexibilidade de horário. Investiu R$ 5000.00." +
                    " Ganhou 3 pontos de imagem."},
                //Vetor que armazena as consequências das alternativas "B" das Perguntas Caso
                gbConsequencia2 = new List<string> {
                    "Você protege sua imagem mas ainda não tem um fornecedor que agregue um valor à sua marca. Não fatura." +
                    " Ganhou 4 pontos de imagem.",
                    "Durante a negociação a Engessada aumentou ainda mais seu preço já o prazo de entrega ficaria abaixo do" +
                    " estipulado na negociação e geraria estoque não previsto. Perdeu R$ 5000.00. Perdeu 3 pontos de imagem.",
                    "Considera a busca apenas no mercado nacional e investe em parcerias nacionais agregando ainda mais valor" +
                    " nacional ao produto. Investiu R$ 7000.00 em pesquisa de mercado. Ganhou 4 pontos de imagem.",
                    "Não houve gastos com a realização da pesquisa porém segmentar o produto para o público errado gera prejuízos" +
                    " onerosos e denigre a imagem da empresa Não houve investimento em pesquisas. Perdeu 6 pontos de imagem.",
                    "A participação em feiras de negócios é muito recomendável para pequenas empresas visto que possui custos" +
                    " baixos e é uma fonte de informações do mercado onde o empreendedor tem acesso a concorrentes novas" +
                    " tecnologias inovações em produtos e processos como também há a possibilidade de encontrar clientes atuais" +
                    " e potenciais. Investiu R$ 2000.00 porém aumentou o faturamento em R$ 6000.00. Ganhou 5 pontos de imagem.",
                    "A opção é caracterizada atualmente como obsoleta irá gerar custos e não será efetivo o resultado. " +
                    "Perdeu R$ 1000.00. Perdeu 3 pontos de imagem.",
                    "Cliente aceitou e pagou corretamente. Dias depois eles mandaram um e-mail elogiando a entrega e a qualidade" +
                    " do material. Faturou R$ 38000.00. Ganhou 5 pontos de imagem.",
                    "Carga chegou com sucesso porém no momento do pagamento devido a variação cambial o dólar valorizou para 4.251." +
                    " Caixa diminuiu em R$ 18713.00 para pagar o fornecedor. Perdeu 4 pontos de imagem.",
                    "Parabéns. Os especialistas estavam corretos e o dólar apreciou para R$ 5.10 e tornou a operação mais vantajosa." +
                    " Faturou R$ 26520.00. Ganhou 1 ponto de imagem.",
                    "Modal rápido com a utilização do Incoterm correto. Investiu R$ 4000.00 com o frete porém faturou R$ 35000.00" +
                    " com a venda extra. Ganhou 8 pontos de imagem.",
                    "A carga caiu no mar você terá que arcar com os gastos que o seguro contratado não cobriu. Perdeu R$ 45000.00." +
                    " Perdeu 10 pontos de imagem.",
                    "Para a utilização do Incoterm FOB a contratação do seguro é facultativa. Porém para a utilização do" +
                    " Incoterm CIF (Cost Insurance and Fraight) é obrigatório a contratação do seguro. Perdeu R$ 1000.00 pela" +
                    " falta de informação. Perdeu 3 pontos de imagem.",
                    "Embora esse modal seja indicado para levar mercadorias de baixo e médio valor agregado ele é relativamente" +
                    " lento para atender remessa com urgência como o solicitado pelo cliente. Investiu R$ 2000.00 com o frete e" +
                    " perdeu R$ 4000.00 com pagamento de multas. Porém faturou R$ 15000.00 com a venda. Perdeu: 8 pontos de imagem.",
                    "Como é uma demanda futura que está sendo feita a partir de um planejamento essa é melhor escolha você" +
                    " economizará no frete e pode investir em outras áreas. Investiu R$ 2000.00. Ganhou 9 pontos de imagem.",
                    "Como não é uma demanda de urgência essa é melhor escolha você economizar no frete e pode investir em outras" +
                    " áreas ganhando pontos por ser uma empresa que uso conscientemente o dinheiro. Investiu R$ 2000.00. Ganhou" +
                    " 9 pontos de imagem.",
                    "O colaborador escolheu trabalhar até mais tarde. Investiu R$ 2000.00 mas atendeu o cliente no prazo correto." +
                    " Ganhou 3 pontos de imagem.",
                    "Gerou custos que não estavam previstos e gerou o pedido de demissão do colaborador que estava a anos na" +
                    " empresa. Perdeu R$ 5000.00. Perdeu 3 pontos de imagem.",
                    "Você realizou um alto investimento contudo não precisa esperar um funcionário se capacitar para poder" +
                    " realizar o trabalho. Investiu R$ 8000.00. Ganhou 2 pontos de imagem."},
                //Vetor que armazena as consequências das alternativas "C" das Perguntas Caso
                gbConsequencia3 = new List<string> {
                    "Você poupa o caixa da empresa para não pagar uma multa ecológica apresentada. Faturou R$ 4000.00. Perdeu " +
                    "4 pontos de imagem.",
                    "A Engessada oferece uma nova proposta para alavancar ainda mais sua visibilidade no mercado internacional." +
                    " Investiu R$ 3000.00 e faturou R$ 5000.00 com a visibilidade. Ganhou 3 pontos de imagem.",
                    "Optando por essa negociação você agrega valor a marca com uma empresa que tem certificações válidas uma cadeia" +
                    " de Supply Chain condizente com a da empresa porém não tem um ganho muito efetivo no caixa já que a redução" +
                    " de preço é limitada. Faturou R$ 5000.00 com as boas parcerias. Ganhou 6 pontos de imagem.",
                    "Houve uma economia em relação aos gastos do estudo porém adotar uma percepção isolada da realidade pode" +
                    " comprometer toda a estratégia. Investiu R$ 3500.00 e faturou R$ 4500.00. Perdeu 1 ponto de imagem.",
                    "O jornal possui uma segmentação específica por isso seus anúncios podem ser facilmente adaptado para" +
                    " determinada região além de possuir a diagramação diário que permite manter os anúncios sempre atuais" +
                    " entretanto isso torna também a vida útil do mesmo curta e impactar o leitor em tão pouco tempo não é uma" +
                    " tarefa fácil. Investiu R$ 1000.00. Ganhou 1 ponto de imagem.",
                    "A opção é a mais indicada para empresas de pequeno porte pois além de possuir custos baixos atinge a" +
                    " população em massa de maneira rápida e direta. Investiu R$ 500.00 porém obteve um retorno de R$ 8000.00 no" +
                    " faturamento. Ganhou 5 pontos de imagem.",
                    "Cliente aceitou porém demorou 30 dias para pagar os 25% faturado e não quis arcar com os juros e multas." +
                    " Você teve que aceitar e por esse motivo houve um desencaixe no seu fluxo de caixa e teve que pagar juros a" +
                    " outros fornecedores. Perdeu R$ 200.00. Perdeu 2 pontos de imagem.",
                    "Carga chegou com atraso de 5 dias porém não houveram maiores danos. Caixa diminuiu em R$ 40000.00 para pagar" +
                    " o fornecedor. Ganhou 3 pontos de imagem.", "A cotação se manteve. Faturou R$ 24960.00. Ganhou 1 ponto de" +
                    " imagem.",
                    "Incoterm compatível com a operação porém o modal é lento. Investiu R$ 5000.00 com o frete e seguro pagou" +
                    " R$ 6000.00 de multas por atraso porém faturou R$ 35000.00 com a venda. Perdeu 6 pontos de imagem.",
                    "Infelizmente ocorreu um acidente e toda a carga foi danificada. Perdeu R$ 35000.00. Perdeu 10 pontos de imagem.",
                    "Parabéns! Para a utilização destes dois Incoterms é obrigatório a contratação do seguro de carga. Faturou" +
                    " R$ 1000.00 por ter a informação correta. Ganhou 3 pontos de imagem.",
                    "O modal ferroviário é o mais indicado para grandes quantidades de carga embora seja uma opção que oferece" +
                    " economia de escala não é o mais indicado para o envio dessa mercadoria principalmente pela malha ferroviária" +
                    " precária que temos em ambos países. Investiu R$ 1000.00 com o frete e perdeu R$ 6000.00 pelo atraso." +
                    " Porém faturou R$ 15000.00 com a venda. Perdeu 8 pontos de imagem.",
                    "Esse tipo de modal não atende Brasil x Colômbia. Investiu R$ 5000.00. Perdeu 8 pontos de imagem.",
                    "Esse tipo de modal não atende Brasil x Colômbia. Perdeu: R$ 5000.00. Perdeu 8 pontos de imagem.",
                    "Devido a demora da emissão do Packlist List o prazo do processo de exportação aumentou e a mercadoria ficou" +
                    " parada em estoque. Perdeu R$ 4000.00 pela demora. Perdeu 3 pontos de imagem.",
                    "Gerou custo com idas e voltas de passagem para o país porém o colaborador ainda consegue ficar próximo a" +
                    " família no Brasil. Perdeu R$ 4000.00. Ganhou 3 pontos de imagem.",
                    "Você investiu pouco e obteve um resultado satisfatório visto que o funcionário gostou do benefício. Investiu" +
                    " R$ 3000.00. Ganhou 3 pontos de imagem."},
                //Vetor que armazena as consequências das alternativas "D" das Perguntas Caso
                gbConsequencia4 = new List<string> {
                    "Aumenta o seu preço final pois caso ocorra a multa a empresa possui caixa para arcar com a multa apresentada." +
                    " Perdeu R$ 7000.00. Perdeu 7 pontos de imagem.",
                    "Considerando as novas aberturas de mercado e o prazo de entrega do material a parceria foi firmada e as" +
                    " condições de negociação serão discutidas depois da primeira entrega. Perdeu R$ 5000.00 pelo reajuste de" +
                    " valor porém não deixou de faturar R$ 6000.00 pelo primeiro pedido. Ganhou 3 pontos de imagem.",
                    "Ao arriscar nesse mercado existem diversos tipos de empresas que não possuem os critérios mencionados e o" +
                    " impacto negativo para a marca é grande. Perdeu R$ 5000.00 pelos riscos. Perdeu 4 pontos de imagem.",
                    "A finalização do estudo é mais curta porém adotou uma medida que há o risco inerente das pessoas responderem" +
                    " de forma rápida e desatenta apenas para completar o ciclo gerando uma percepção distorcida da realidade." +
                    " Investiu R$ 2000.00 sem ter a exatidão do retorno. Perdeu 2 pontos de imagem.",
                    "A mídia OOH possui como objetivo alcançar as pessoas em outros espaços e assim aumentar a presença de marca." +
                    " Possui custos médios porém é necessário uma análise prévia dos pontos estratégicos e da qualidade do material" +
                    " utilizado. Investiu R$ 2000.00 e aumentou o seu faturamento em R$ 1000.00. Ganhou 2 pontos de imagem.",
                    "A opção familiariza o produto aos colombianos porém para ser efetivo deve ser realizada em conjunto com outra" +
                    " ação de capitação de consumidores além de possuir custos de criação e manutenção que precisam ser" +
                    " previamente analisados. Investiu R$ 1000.00. Ganhou 2 pontos de imagem.",
                    "Cliente não aceitou e cancelou a compra. Não ganhou dinheiro. Perdeu 2 pontos de imagem.",
                    "Carga chegou corretamente. Caixa diminuiu em R$ 17264.00 para pagar o fornecedor. Ganhou 3 pontos de imagem.",
                    "Carga chegou corretamente. Faturou R$ 24440.00. Não recebe ponto de imagem.",
                    "Incoterm compatível com a operação porém o modal é lento. Investiu R$ 5000.00 com o frete e seguro pagou" +
                    " R$ 6000.00 de multas por atraso porém faturou R$ 35000.00 com a venda. Perdeu 6 pontos de imagem.",
                    "Que sorte! Correu o risco de sofrer um acidente e o mesmo não ocorreu. Faturou R$ 35000.00 pela venda." +
                    " Perdeu 5 pontos de imagem pelo risco que correu.",
                    "O Incoterm DIP não existe! E para o Incoterm  CFR a contratação do seguro de carga é facultativa. Perdeu" +
                    " R$ 1000.00 pela falta de informação. Perdeu 3 pontos de imagem.",
                    "Para o envio por esse modal o tempo será muito elevado isso sem contar o valor do seguro de carga para o" +
                    " transporte da mercadoria entre Brasil e Colômbia. Investiu R$ 6000.00 com o frete e seguro e perdeu" +
                    " R$ 8000.00 pelo atraso. Porém faturou R$ 15000.00 com a venda. Perdeu 8 pontos de imagem.",
                    "Para o envio por esse modal o tempo será muito elevado isso sem contar o valor elevado de seguro de carga" +
                    " para o transporte da mercadoria entre Brasil e Colômbia. Investiu R$ 6000.00. Perdeu 8 pontos de imagem.",
                    "Para o envio por esse modal o tempo será muito elevado isso sem contar o valor elevado de seguro de carga" +
                    " para o transporte da mercadoria entre Brasil e Colômbia. Perdeu R$ 6000.00. Perdeu 8 pontos de imagem.",
                    "Sua atitude gerou um processo trabalhista. Perdeu R$ 7000.00. Perdeu 5 pontos de imagem.",
                    "Gerou o custo com a contratação e treinamento do colaborador no Brasil porém gerou empregos no mercado" +
                    " colombiano. Perdeu R$ 5000.00. Ganhou 3 pontos de imagem.",
                    "Houve um investimento considerável entretanto o funcionário que recebeu o treinamento ficou muito satisfeito" +
                    " pelo benefício. Investiu R$ 4000.00. Ganhou 4 pontos de imagem."},
                //Lista que armazena os nicknames
                gbRankingNome = new List<string>();

        public static StreamReader Save;


        public static string
            gbNickname = "", //Variável para armazenar nickname do jogador                   - Telas Pontuação/Ranking
            gbRespostaCaso = "", //Variável para armazenar texto da resposta Caso            - Tela Respota Caso
            gbConsequenciaCaso = ""; //Variável para armazenar texto da consequência Caso    - Tela Resposta Caso
    }
}
