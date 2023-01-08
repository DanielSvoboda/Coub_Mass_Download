﻿using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coub_Download
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox_Comunidade.Text = "memes";
        }

        string local_run_app = Directory.GetCurrentDirectory();  // diretorio da execução do programa 
        string nomes_dos_arquivos;                               // nomes dos arquivos
        string links_coub;                                       // links dos videos do coub
        string periodo = "daily";
        string fonte_pesq = "timeline/community/memes";
        bool console = false;

        int total_para_baixar = 0;
        int total_ja_baixados = 0;

        private void Botao_Click(object sender, EventArgs e)    // botao unico que faz tudo
        {
            pegar_links();              // OK
         // REMOVER_DUPLI();            // desnecessário
            baixar_coub();              // OK
            copiar_intro_fim();         // OK
            nomes_arquivos();           // OK
            unir_videos();              // OK
            apagar_arquivos();          // OK
             
            MessageBox.Show("TUDO Ok !!!");
        }

        public void log(string conteudo)        //função para enviar texto para o 'console'
        {
            textBox_resultado_nome_arquivos.AppendText(conteudo + Environment.NewLine + Environment.NewLine);
        }


        void pegar_links()     // obter link's dos vídeos
        {
            total_para_baixar = 0;
            links_coub = "";
            log("INICIANDO: 'pegar_links'...");

            if (radioButton_comunidade.Checked == true)
            {
                fonte_pesq = "timeline/community/" + comboBox_Comunidade.Text;
            }

            if (radioButton_subscriptions.Checked == true)
            {
                fonte_pesq = "timeline/subscriptions";
            }

            int paginas = Convert.ToInt32(textBox_paginas.Text);
            for (int i = 1; i != paginas + 1; i++)     // vai de 1 ate o tamanho da pagina 
            {
                string URL;
                if (radioButton_pesquisar.Checked == true)
                {
                    URL = "https://coub.com/api/v2/search?q=" + textBox_pesquisar.Text + "&order_by=" + comboBox_order_by.Text + "&page=" + i;
                }
                else
                {
                    URL = "https://coub.com/api/v2/" + fonte_pesq + "/" + periodo + "?per_page=25&page=" + i + "&order_by=" + comboBox_order_by.Text;
                }

                WebRequest solicitacao = HttpWebRequest.Create(URL);
                WebResponse resposta = solicitacao.GetResponse();
                StreamReader ler_get = new StreamReader(resposta.GetResponseStream());
                JObject conteudo_pagina = JObject.Parse(ler_get.ReadToEnd());

                progressBar1.Value = 10;

                var obj_video = from p in conteudo_pagina["coubs"]
                                select (string)p["file_versions"]["share"]["default"];     // links dos videos

                foreach (var item in obj_video)
                {
                    if (item != null)                                   // se o link nao for 'null'
                    {
                        links_coub += item + Environment.NewLine;       // alimenta a variavel com os links e pula linha      
                        total_para_baixar++;
                        progressBar1.Value++;
                    }                     
                }

               // links_coub = links_coub.Remove(links_coub.Length - 1);  // remove o ultimo espaço 
            }

            progressBar1.Value = 100;
            progressBar2.Maximum = total_para_baixar;
            log(links_coub);          // add links na tela preta -log
            log("-CONCLUÍDO: 'pegar_links'");
            //var obj_imagem = from p in conteudo_pagina["coubs"]
            //                  select(string)p["picture"];             // links da imagem

            //var obj_itulo = from p in conteudo_pagina["coubs"]
            //                  select(string)p["title"];               // nome do titulo
        }


        public void baixar_coub()           // baixa os arquivos referente aos link's armazenados na variavel links_coub
        {
            log("-INICIANDO: 'baixar_coub'...");
            total_ja_baixados = 0;
            progressBar2.Value = 0;

            //using (var reader = new StringReader(links_coub))
            //    for (string url_line = reader.ReadLine(); url_line != null; url_line = reader.ReadLine())
            //    {
            //        string nomeDoArquivo = Path.GetFileName(url_line);
            //        var client = new WebClient();

            //        client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            //        client.DownloadFileAsync(new Uri(url_line), Directory.GetCurrentDirectory() + @"\videos\" + nomeDoArquivo);

            //    }

            using (var baixadeiro = new WebClient())
            using (var reader = new StringReader(links_coub))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string fileName = Path.GetFileName(line);
                    baixadeiro.DownloadFile(line, Directory.GetCurrentDirectory() + @"\videos\" + fileName);
                    total_ja_baixados++;
                    progressBar2.Value++;
                }
            }
        }


        public void Completed(object sender, AsyncCompletedEventArgs e)
        {
            total_ja_baixados++; //da pra apagar quase tudo isso
            progressBar2.Value++;
            groupBox_funcoes.Text = total_ja_baixados.ToString();            
        }



        public void copiar_intro_fim()      // copia os arquivos de intro e fim para pasta videos, renomeado
        {
            log("-INICIANDO: 'copiar_intro_fim'...");

            File.Copy(local_run_app + @"\intro.mp4", local_run_app + @"\videos\1.mp4", true);
            File.Copy(local_run_app + @"\fim.mp4", local_run_app + @"\videos\z.mp4", true);

            log("-CONCLUÍDO: 'copiar_intro_fim'\nOS ARQUIVOS intro.mp4(1.mp4) e fim.mp4(z.mp4) foram copiados para pasta /videos");
        }


        public void nomes_arquivos()
        {
            log("-INICIANDO: 'nomes_arquivos'...");

            nomes_dos_arquivos = "";
            DirectoryInfo directory = new DirectoryInfo(local_run_app + @"\videos");
            var files = directory.GetFiles("*.mp4");

            foreach (var file in files)     // repete ate o total de arquivo .mp4 que existe na pasta
            {
                nomes_dos_arquivos += "file " + file.Name.ToString() + Environment.NewLine;     // file banana.mp4  -nova_linha
            }

            nomes_dos_arquivos = nomes_dos_arquivos.Remove(nomes_dos_arquivos.Length - 2);      // remove 2 ultimos caracteres, em branco        
            log("ARQUIVOS NA PASTA /VIDEOS:" + Environment.NewLine + nomes_dos_arquivos);
            File.AppendAllText(directory + @"/nome_dos_arquivos.txt", nomes_dos_arquivos);      // cria o arquivo txt com os nomes na pasta video

            log("-CONCLUÍDO: 'nomes_arquivos'\nnome_dos_arquivos.txt FOI SALVO DA PASTA /VIDEOS");
        }



        public void unir_videos()
        {
            log("-INICIANDO: 'unir_videos'...");

            //if (total_ja_baixados == total_para_baixar)
            //{
                //ffmpeg -safe 0 -f concat -i videos/nome_dos_arquivos.txt -c copy output.mp4
                //string comando = " -y -f concat -r 25 -safe 0 -i videos/nome_dos_arquivos.txt -c copy output.mp4";

                string comando = @" -safe 0 -f concat -i videos/nome_dos_arquivos.txt -vf scale=iw*min(1280/iw\,720/ih):ih*min(1280/iw\,720/ih),pad=1280:720:(1280-iw*min(1280/iw\,720/ih))/2:(720-ih*min(1280/iw\,720/ih))/2 output.mp4";

                string localFfmpeg = Path.Combine(local_run_app, "ffmpeg.exe");

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;   // true = invisivel   false=mostra o console preto
                startInfo.UseShellExecute = false; // só funciona false
                startInfo.FileName = localFfmpeg;
                //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = comando;

                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;

                using (Process exeProcess = Process.Start(startInfo))
                {
                    string error = exeProcess.StandardError.ReadToEnd();
                    string output = exeProcess.StandardOutput.ReadToEnd();
                    exeProcess.WaitForExit();
                    log(error);
                }

                log("-CONCLUÍDO: 'unir_videos'\nVÍDEOS UNIFICADOS! -acima contem o log do ffmpeg");
            //}
            //else
            //{
            //    log("Total:" + total_para_baixar + "    Baixado:" + progressBar2.Value + " a " + total_ja_baixados);
            //    System.Threading.Thread.Sleep(3000);
            //    unir_videos();
            //}
        }



        public void apagar_arquivos()
        {
            log("INICIANDO: 'apagar_arquivos'...");

            string[] arquivos_diretorio_app = Directory.GetFiles(local_run_app + @"\videos");
            foreach (string filePath in arquivos_diretorio_app)
                File.Delete(filePath);

            log("-CONCLUÍDO: 'apagar_arquivos'\nARQUIVOS DA PASTA 'VIDEOS' FORAM APAGADOS!");
        }



        void REMOVER_DUPLI()        //nesse contexto essa função é inútil
        {
            textBox_resultado_nome_arquivos.Text = links_coub;                          //o textbox recebe o conteudo da variavel
            var names = textBox_resultado_nome_arquivos.Lines.Distinct();               //a variavel names recebe textbox
            textBox_resultado_nome_arquivos.Clear();                                    //textbox clear

            foreach (string name in names)
            {
                textBox_resultado_nome_arquivos.AppendText(name + Environment.NewLine); // readiciona no texbox o conteudo sem duplicar
            }

            links_coub = textBox_resultado_nome_arquivos.Text;                          // por fim a variavel recebe o conteudo do textbox
        }



        //Grupo = Vídeos do periodo:
        private void button1_Click(object sender, EventArgs e)
        { pegar_links(); MessageBox.Show("OK"); }

        private void button_REMOVER_DUPLI_Click(object sender, EventArgs e)
        { REMOVER_DUPLI(); MessageBox.Show("OK"); }

        private void button_baixar_coub_Click(object sender, EventArgs e)
        { baixar_coub(); MessageBox.Show("OK"); }

        private void button_copiar_intro_fim_Click(object sender, EventArgs e)
        { copiar_intro_fim(); MessageBox.Show("OK"); }

        private void button_nomes_arquivos_Click(object sender, EventArgs e)
        { nomes_arquivos(); MessageBox.Show("OK"); }

        private void button_unir_videos_Click(object sender, EventArgs e)
        { unir_videos(); MessageBox.Show("OK"); }

        private void button_apagar_arquivos_Click(object sender, EventArgs e)
        { apagar_arquivos(); MessageBox.Show("OK"); }



        // Grupo = periodo        
        private void radioButton_daily_CheckedChanged(object sender, EventArgs e)
        { periodo = "daily"; }

        private void radioButton_weekly_CheckedChanged(object sender, EventArgs e)
        { periodo = "weekly"; }

        private void radioButton_monthly_CheckedChanged(object sender, EventArgs e)
        { periodo = "monthly"; }

        private void radioButton_quarter_CheckedChanged(object sender, EventArgs e)
        { periodo = "quarter"; }

        private void radioButton_half_CheckedChanged(object sender, EventArgs e)
        { periodo = "half"; }



        private void button_console_Click(object sender, EventArgs e)
        {
            visualizar_console();
        }

        private void visualizar_console()
        {
            if (console == true)
            {
                console = false;
                this.Size = new Size(463, 297);     //altera o tamanho do form
                this.CenterToScreen();              //centraliza o form
                button_console.Text = "Console ▼";
            }
            else
            {
                console = true;
                this.Size = new Size(1034, 713);     //altera o tamanho do form
                this.CenterToScreen();              //centraliza o form
                button_console.Text = "Console ▲";
            }
        }


        private void linkLabel_sobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DanielSvoboda");   //botão sobre
        }
    }
}