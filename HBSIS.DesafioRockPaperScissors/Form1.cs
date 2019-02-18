using HBSIS.DesafioRockPaperScissors.Contracts;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace HBSIS.DesafioRockPaperScissors
{
    public partial class frmJogo : Form
    {
        private readonly IList<Jogo> listaJogos = new List<Jogo>();

        public frmJogo()
        {
           
            InitializeComponent();

            btnJogar.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarEntradaDados(List<Jogo> jogos)
        {
            int contaJogadores = jogos.Count();
            const string messageWrongNumberOfPlayersError = "Número de jogadores tem que ser igual a 2";
            const string messageNoSuchStrategyError = "Tipo de estratégia errado";

            if (contaJogadores != 2)
            {
                throw new WrongNumberOfPlayersError(messageWrongNumberOfPlayersError);
            }



            var tipos = jogos.Where(x => x.tipo.ToString() != "R"
                                       && x.tipo.ToString() != "S" && x.tipo.ToString() != "P").ToList();


            if(tipos.Count() > 0)
            {
                throw new NoSuchStrategyError(messageNoSuchStrategyError);
            }

            return true;
        }



        private void btnEscolherArquivo_Click(object sender, EventArgs e)
        {
            this.ofd1.Multiselect = false;
            this.ofd1.Title = "Selecionar Arquivo - Jogo";
            ofd1.InitialDirectory = @"C";
            ofd1.Filter = "JSON (*.JSON)|*.JSON";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;


            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == DialogResult.OK)
            {


                txtArquivo.Text = ofd1.FileName;
                try
                {
                    string jsonString = File.ReadAllText(txtArquivo.Text);


                    JObject searchJogos = JObject.Parse(jsonString);

                    IList<JToken> results = searchJogos["torneio"]["jogo"].Children().ToList();


                   
                    foreach (JToken result in results)
                    {
                        Jogo searchJogo = JsonConvert.DeserializeObject<Jogo>(result.ToString());
                        listaJogos.Add(searchJogo);
                    }


                     bool ret = ValidarEntradaDados(listaJogos.ToList());

                    if (ret) btnJogar.Enabled = true;


                }
                catch (Exception ex)
                {
                    btnJogar.Enabled = false;
                    listaJogos.Clear();
                    string msg = ex.Message;
                    throw;
                }

               

            }



        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            this.rps_game_winner(listaJogos.ToList());
        }



        public void rps_game_winner(List<Jogo> jogos)
        {
            string[] nomes;
            nomes = new string[2];

            string[] tipos;
            tipos = new string[2];

            int i = 0;

            foreach (var jogador in jogos)
            {
                nomes[i] = jogador.nome;
                tipos[i] = jogador.tipo;

                i++;
            }

            string vencedor = ApurarVencedor(nomes, tipos);

            MessageBox.Show(string.Format("O jogador {0} ganhou o jogo!", vencedor),"Informação",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

        }



        private string ApurarVencedor(string[] nomes, string[] tipos)
        {
            if( tipos[0] == "R" &&  tipos[1] == "S")
            {
                return nomes[0];
            }
            else if(tipos[1] == "R" && tipos[0] == "S")
            {
                return nomes[1];
            }
            else if(tipos[0] == "S" && tipos[1] == "P")
            {
                return nomes[0];
            }
            else if (tipos[1] == "S" && tipos[0] == "P")
            {
                return nomes[1];
            }
            else if (tipos[0] == "P" && tipos[1] == "R")
            {
                return nomes[0];
            }
            else if (tipos[1] == "P" && tipos[0] == "R")
            {
                return nomes[1];
            }


            else if (tipos[0] == "S" && tipos[1] == "S")
            {
                return nomes[0];
            }
            else if (tipos[1] == "S" && tipos[0] == "S")
            {
                return nomes[1];
            }

            else if (tipos[0] == "P" && tipos[1] == "P")
            {
                return nomes[0];
            }
            else if (tipos[1] == "P" && tipos[0] == "P")
            {
                return nomes[1];
            }

            else if (tipos[0] == "R" && tipos[1] == "R")
            {
                return nomes[0];
            }
            else if (tipos[1] == "R" && tipos[0] == "R")
            {
                return nomes[1];
            }

            return "Sem Vencedor";

        }



    }
}
