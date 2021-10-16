namespace Coub_Download
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_resultado_nome_arquivos = new System.Windows.Forms.TextBox();
            this.Botao_TUDO = new System.Windows.Forms.Button();
            this.button_pegar_links = new System.Windows.Forms.Button();
            this.button_nomes_arquivos = new System.Windows.Forms.Button();
            this.button_baixar_coub = new System.Windows.Forms.Button();
            this.button_unir_videos = new System.Windows.Forms.Button();
            this.button_apagar_arquivos = new System.Windows.Forms.Button();
            this.radioButton_daily = new System.Windows.Forms.RadioButton();
            this.radioButton_weekly = new System.Windows.Forms.RadioButton();
            this.radioButton_quarter = new System.Windows.Forms.RadioButton();
            this.radioButton_monthly = new System.Windows.Forms.RadioButton();
            this.radioButton_half = new System.Windows.Forms.RadioButton();
            this.textBox_comunidade = new System.Windows.Forms.TextBox();
            this.textBox_paginas = new System.Windows.Forms.TextBox();
            this.label_paginas = new System.Windows.Forms.Label();
            this.groupBox_periodos = new System.Windows.Forms.GroupBox();
            this.groupBox_ondeProcurar = new System.Windows.Forms.GroupBox();
            this.radioButton_comunidade = new System.Windows.Forms.RadioButton();
            this.radioButton_pesquisar = new System.Windows.Forms.RadioButton();
            this.textBox_pesquisar = new System.Windows.Forms.TextBox();
            this.radioButton_subscriptions = new System.Windows.Forms.RadioButton();
            this.button_ver_num_comunidades = new System.Windows.Forms.Button();
            this.label_order_by = new System.Windows.Forms.Label();
            this.comboBox_order_by = new System.Windows.Forms.ComboBox();
            this.groupBox_funcoes = new System.Windows.Forms.GroupBox();
            this.button_copiar_intro_fim = new System.Windows.Forms.Button();
            this.button_console = new System.Windows.Forms.Button();
            this.linkLabel_sobre = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_outros = new System.Windows.Forms.GroupBox();
            this.groupBox_periodos.SuspendLayout();
            this.groupBox_ondeProcurar.SuspendLayout();
            this.groupBox_funcoes.SuspendLayout();
            this.groupBox_outros.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_resultado_nome_arquivos
            // 
            this.textBox_resultado_nome_arquivos.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox_resultado_nome_arquivos.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_resultado_nome_arquivos.ForeColor = System.Drawing.Color.Lime;
            this.textBox_resultado_nome_arquivos.Location = new System.Drawing.Point(12, 308);
            this.textBox_resultado_nome_arquivos.Multiline = true;
            this.textBox_resultado_nome_arquivos.Name = "textBox_resultado_nome_arquivos";
            this.textBox_resultado_nome_arquivos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_resultado_nome_arquivos.Size = new System.Drawing.Size(920, 365);
            this.textBox_resultado_nome_arquivos.TabIndex = 43;
            // 
            // Botao_TUDO
            // 
            this.Botao_TUDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_TUDO.Location = new System.Drawing.Point(6, 17);
            this.Botao_TUDO.Name = "Botao_TUDO";
            this.Botao_TUDO.Size = new System.Drawing.Size(95, 42);
            this.Botao_TUDO.TabIndex = 41;
            this.Botao_TUDO.Text = "INICIAR (TUDO)";
            this.Botao_TUDO.UseVisualStyleBackColor = true;
            this.Botao_TUDO.Click += new System.EventHandler(this.Botao_Click);
            // 
            // button_pegar_links
            // 
            this.button_pegar_links.Location = new System.Drawing.Point(6, 65);
            this.button_pegar_links.Name = "button_pegar_links";
            this.button_pegar_links.Size = new System.Drawing.Size(70, 23);
            this.button_pegar_links.TabIndex = 45;
            this.button_pegar_links.Text = "Pegar_links";
            this.button_pegar_links.UseVisualStyleBackColor = true;
            this.button_pegar_links.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_nomes_arquivos
            // 
            this.button_nomes_arquivos.Location = new System.Drawing.Point(6, 153);
            this.button_nomes_arquivos.Name = "button_nomes_arquivos";
            this.button_nomes_arquivos.Size = new System.Drawing.Size(95, 23);
            this.button_nomes_arquivos.TabIndex = 48;
            this.button_nomes_arquivos.Text = "Nomes_arquivos";
            this.button_nomes_arquivos.UseVisualStyleBackColor = true;
            this.button_nomes_arquivos.Click += new System.EventHandler(this.button_nomes_arquivos_Click);
            // 
            // button_baixar_coub
            // 
            this.button_baixar_coub.Location = new System.Drawing.Point(6, 94);
            this.button_baixar_coub.Name = "button_baixar_coub";
            this.button_baixar_coub.Size = new System.Drawing.Size(75, 23);
            this.button_baixar_coub.TabIndex = 47;
            this.button_baixar_coub.Text = "Baixar_Coub";
            this.button_baixar_coub.UseVisualStyleBackColor = true;
            this.button_baixar_coub.Click += new System.EventHandler(this.button_baixar_coub_Click);
            // 
            // button_unir_videos
            // 
            this.button_unir_videos.Location = new System.Drawing.Point(6, 182);
            this.button_unir_videos.Name = "button_unir_videos";
            this.button_unir_videos.Size = new System.Drawing.Size(71, 23);
            this.button_unir_videos.TabIndex = 49;
            this.button_unir_videos.Text = "Unir_videos";
            this.button_unir_videos.UseVisualStyleBackColor = true;
            this.button_unir_videos.Click += new System.EventHandler(this.button_unir_videos_Click);
            // 
            // button_apagar_arquivos
            // 
            this.button_apagar_arquivos.Location = new System.Drawing.Point(6, 211);
            this.button_apagar_arquivos.Name = "button_apagar_arquivos";
            this.button_apagar_arquivos.Size = new System.Drawing.Size(95, 23);
            this.button_apagar_arquivos.TabIndex = 50;
            this.button_apagar_arquivos.Text = "Apagar_arquivos";
            this.button_apagar_arquivos.UseVisualStyleBackColor = true;
            this.button_apagar_arquivos.Click += new System.EventHandler(this.button_apagar_arquivos_Click);
            // 
            // radioButton_daily
            // 
            this.radioButton_daily.AutoSize = true;
            this.radioButton_daily.Checked = true;
            this.radioButton_daily.Location = new System.Drawing.Point(6, 19);
            this.radioButton_daily.Name = "radioButton_daily";
            this.radioButton_daily.Size = new System.Drawing.Size(41, 17);
            this.radioButton_daily.TabIndex = 51;
            this.radioButton_daily.TabStop = true;
            this.radioButton_daily.Text = "Dia";
            this.radioButton_daily.UseVisualStyleBackColor = true;
            this.radioButton_daily.CheckedChanged += new System.EventHandler(this.radioButton_daily_CheckedChanged);
            // 
            // radioButton_weekly
            // 
            this.radioButton_weekly.AutoSize = true;
            this.radioButton_weekly.Location = new System.Drawing.Point(47, 19);
            this.radioButton_weekly.Name = "radioButton_weekly";
            this.radioButton_weekly.Size = new System.Drawing.Size(64, 17);
            this.radioButton_weekly.TabIndex = 52;
            this.radioButton_weekly.Text = "Semana";
            this.radioButton_weekly.UseVisualStyleBackColor = true;
            this.radioButton_weekly.CheckedChanged += new System.EventHandler(this.radioButton_weekly_CheckedChanged);
            // 
            // radioButton_quarter
            // 
            this.radioButton_quarter.AutoSize = true;
            this.radioButton_quarter.Location = new System.Drawing.Point(168, 19);
            this.radioButton_quarter.Name = "radioButton_quarter";
            this.radioButton_quarter.Size = new System.Drawing.Size(69, 17);
            this.radioButton_quarter.TabIndex = 54;
            this.radioButton_quarter.Text = "3 messes";
            this.radioButton_quarter.UseVisualStyleBackColor = true;
            this.radioButton_quarter.CheckedChanged += new System.EventHandler(this.radioButton_quarter_CheckedChanged);
            // 
            // radioButton_monthly
            // 
            this.radioButton_monthly.AutoSize = true;
            this.radioButton_monthly.Location = new System.Drawing.Point(117, 19);
            this.radioButton_monthly.Name = "radioButton_monthly";
            this.radioButton_monthly.Size = new System.Drawing.Size(45, 17);
            this.radioButton_monthly.TabIndex = 53;
            this.radioButton_monthly.Text = "Mês";
            this.radioButton_monthly.UseVisualStyleBackColor = true;
            this.radioButton_monthly.CheckedChanged += new System.EventHandler(this.radioButton_monthly_CheckedChanged);
            // 
            // radioButton_half
            // 
            this.radioButton_half.AutoSize = true;
            this.radioButton_half.Location = new System.Drawing.Point(243, 19);
            this.radioButton_half.Name = "radioButton_half";
            this.radioButton_half.Size = new System.Drawing.Size(69, 17);
            this.radioButton_half.TabIndex = 55;
            this.radioButton_half.Text = "6 messes";
            this.radioButton_half.UseVisualStyleBackColor = true;
            this.radioButton_half.CheckedChanged += new System.EventHandler(this.radioButton_half_CheckedChanged);
            // 
            // textBox_comunidade
            // 
            this.textBox_comunidade.Location = new System.Drawing.Point(96, 39);
            this.textBox_comunidade.Name = "textBox_comunidade";
            this.textBox_comunidade.Size = new System.Drawing.Size(20, 20);
            this.textBox_comunidade.TabIndex = 56;
            this.textBox_comunidade.Text = "20";
            // 
            // textBox_paginas
            // 
            this.textBox_paginas.Location = new System.Drawing.Point(96, 53);
            this.textBox_paginas.Name = "textBox_paginas";
            this.textBox_paginas.Size = new System.Drawing.Size(20, 20);
            this.textBox_paginas.TabIndex = 61;
            this.textBox_paginas.Text = "3";
            this.toolTip1.SetToolTip(this.textBox_paginas, "Aproximadamente: \r\n\r\nTotal vídeo = 25 vídeos * Paginas\r\nTempo total(min) = Total " +
        "vídeo*10/60");
            // 
            // label_paginas
            // 
            this.label_paginas.AutoSize = true;
            this.label_paginas.Location = new System.Drawing.Point(6, 56);
            this.label_paginas.Name = "label_paginas";
            this.label_paginas.Size = new System.Drawing.Size(48, 13);
            this.label_paginas.TabIndex = 62;
            this.label_paginas.Text = "Paginas:";
            // 
            // groupBox_periodos
            // 
            this.groupBox_periodos.Controls.Add(this.radioButton_daily);
            this.groupBox_periodos.Controls.Add(this.radioButton_weekly);
            this.groupBox_periodos.Controls.Add(this.radioButton_monthly);
            this.groupBox_periodos.Controls.Add(this.radioButton_quarter);
            this.groupBox_periodos.Controls.Add(this.radioButton_half);
            this.groupBox_periodos.Location = new System.Drawing.Point(12, 12);
            this.groupBox_periodos.Name = "groupBox_periodos";
            this.groupBox_periodos.Size = new System.Drawing.Size(313, 42);
            this.groupBox_periodos.TabIndex = 63;
            this.groupBox_periodos.TabStop = false;
            this.groupBox_periodos.Text = "Vídeos do periodo:";
            // 
            // groupBox_ondeProcurar
            // 
            this.groupBox_ondeProcurar.Controls.Add(this.radioButton_comunidade);
            this.groupBox_ondeProcurar.Controls.Add(this.radioButton_pesquisar);
            this.groupBox_ondeProcurar.Controls.Add(this.textBox_pesquisar);
            this.groupBox_ondeProcurar.Controls.Add(this.radioButton_subscriptions);
            this.groupBox_ondeProcurar.Controls.Add(this.button_ver_num_comunidades);
            this.groupBox_ondeProcurar.Controls.Add(this.textBox_comunidade);
            this.groupBox_ondeProcurar.Location = new System.Drawing.Point(129, 60);
            this.groupBox_ondeProcurar.Name = "groupBox_ondeProcurar";
            this.groupBox_ondeProcurar.Size = new System.Drawing.Size(196, 120);
            this.groupBox_ondeProcurar.TabIndex = 64;
            this.groupBox_ondeProcurar.TabStop = false;
            this.groupBox_ondeProcurar.Text = "Onde procurar?";
            // 
            // radioButton_comunidade
            // 
            this.radioButton_comunidade.AutoSize = true;
            this.radioButton_comunidade.Checked = true;
            this.radioButton_comunidade.Location = new System.Drawing.Point(6, 42);
            this.radioButton_comunidade.Name = "radioButton_comunidade";
            this.radioButton_comunidade.Size = new System.Drawing.Size(84, 17);
            this.radioButton_comunidade.TabIndex = 70;
            this.radioButton_comunidade.TabStop = true;
            this.radioButton_comunidade.Text = "Comunidade";
            this.radioButton_comunidade.UseVisualStyleBackColor = true;
            // 
            // radioButton_pesquisar
            // 
            this.radioButton_pesquisar.AutoSize = true;
            this.radioButton_pesquisar.Location = new System.Drawing.Point(6, 65);
            this.radioButton_pesquisar.Name = "radioButton_pesquisar";
            this.radioButton_pesquisar.Size = new System.Drawing.Size(74, 17);
            this.radioButton_pesquisar.TabIndex = 56;
            this.radioButton_pesquisar.Text = "Pesquisar:";
            this.radioButton_pesquisar.UseVisualStyleBackColor = true;
            // 
            // textBox_pesquisar
            // 
            this.textBox_pesquisar.Location = new System.Drawing.Point(6, 88);
            this.textBox_pesquisar.Name = "textBox_pesquisar";
            this.textBox_pesquisar.Size = new System.Drawing.Size(168, 20);
            this.textBox_pesquisar.TabIndex = 68;
            // 
            // radioButton_subscriptions
            // 
            this.radioButton_subscriptions.AutoSize = true;
            this.radioButton_subscriptions.Location = new System.Drawing.Point(6, 19);
            this.radioButton_subscriptions.Name = "radioButton_subscriptions";
            this.radioButton_subscriptions.Size = new System.Drawing.Size(88, 17);
            this.radioButton_subscriptions.TabIndex = 69;
            this.radioButton_subscriptions.Text = "Subscriptions";
            this.radioButton_subscriptions.UseVisualStyleBackColor = true;
            // 
            // button_ver_num_comunidades
            // 
            this.button_ver_num_comunidades.Location = new System.Drawing.Point(122, 39);
            this.button_ver_num_comunidades.Name = "button_ver_num_comunidades";
            this.button_ver_num_comunidades.Size = new System.Drawing.Size(68, 20);
            this.button_ver_num_comunidades.TabIndex = 66;
            this.button_ver_num_comunidades.Text = "Ver lista N°";
            this.toolTip1.SetToolTip(this.button_ver_num_comunidades, "VER OS NUMEROS DAS \'COMUNIDADES\'");
            this.button_ver_num_comunidades.UseVisualStyleBackColor = true;
            this.button_ver_num_comunidades.Click += new System.EventHandler(this.button_ver_num_comunidades_Click);
            // 
            // label_order_by
            // 
            this.label_order_by.AutoSize = true;
            this.label_order_by.Location = new System.Drawing.Point(6, 22);
            this.label_order_by.Name = "label_order_by";
            this.label_order_by.Size = new System.Drawing.Size(66, 13);
            this.label_order_by.TabIndex = 72;
            this.label_order_by.Text = "Ordenar por:";
            // 
            // comboBox_order_by
            // 
            this.comboBox_order_by.FormattingEnabled = true;
            this.comboBox_order_by.Items.AddRange(new object[] {
            "likes_count",
            "views_count",
            "newest",
            "oldest",
            "newest_popular"});
            this.comboBox_order_by.Location = new System.Drawing.Point(96, 19);
            this.comboBox_order_by.Name = "comboBox_order_by";
            this.comboBox_order_by.Size = new System.Drawing.Size(94, 21);
            this.comboBox_order_by.TabIndex = 73;
            this.comboBox_order_by.Text = "likes_count";
            // 
            // groupBox_funcoes
            // 
            this.groupBox_funcoes.Controls.Add(this.button_copiar_intro_fim);
            this.groupBox_funcoes.Controls.Add(this.Botao_TUDO);
            this.groupBox_funcoes.Controls.Add(this.button_pegar_links);
            this.groupBox_funcoes.Controls.Add(this.button_baixar_coub);
            this.groupBox_funcoes.Controls.Add(this.button_nomes_arquivos);
            this.groupBox_funcoes.Controls.Add(this.button_unir_videos);
            this.groupBox_funcoes.Controls.Add(this.button_apagar_arquivos);
            this.groupBox_funcoes.Location = new System.Drawing.Point(12, 60);
            this.groupBox_funcoes.Name = "groupBox_funcoes";
            this.groupBox_funcoes.Size = new System.Drawing.Size(111, 242);
            this.groupBox_funcoes.TabIndex = 66;
            this.groupBox_funcoes.TabStop = false;
            this.groupBox_funcoes.Text = "FUNÇÕES";
            // 
            // button_copiar_intro_fim
            // 
            this.button_copiar_intro_fim.Location = new System.Drawing.Point(6, 124);
            this.button_copiar_intro_fim.Name = "button_copiar_intro_fim";
            this.button_copiar_intro_fim.Size = new System.Drawing.Size(95, 23);
            this.button_copiar_intro_fim.TabIndex = 51;
            this.button_copiar_intro_fim.Text = "Copiar_intro/fim";
            this.button_copiar_intro_fim.UseVisualStyleBackColor = true;
            this.button_copiar_intro_fim.Click += new System.EventHandler(this.button_copiar_intro_fim_Click);
            // 
            // button_console
            // 
            this.button_console.Location = new System.Drawing.Point(257, 279);
            this.button_console.Name = "button_console";
            this.button_console.Size = new System.Drawing.Size(68, 23);
            this.button_console.TabIndex = 72;
            this.button_console.Text = "Console ▼";
            this.toolTip1.SetToolTip(this.button_console, "MOSTRAR/OCULTAR CONSOLE");
            this.button_console.UseVisualStyleBackColor = true;
            this.button_console.Click += new System.EventHandler(this.button_console_Click);
            // 
            // linkLabel_sobre
            // 
            this.linkLabel_sobre.AutoSize = true;
            this.linkLabel_sobre.Location = new System.Drawing.Point(129, 270);
            this.linkLabel_sobre.Name = "linkLabel_sobre";
            this.linkLabel_sobre.Size = new System.Drawing.Size(80, 26);
            this.linkLabel_sobre.TabIndex = 73;
            this.linkLabel_sobre.TabStop = true;
            this.linkLabel_sobre.Text = "Github.com/\r\nDanielSvoboda";
            this.toolTip1.SetToolTip(this.linkLabel_sobre, "https://github.com/DanielSvoboda");
            this.linkLabel_sobre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_sobre_LinkClicked);
            // 
            // groupBox_outros
            // 
            this.groupBox_outros.Controls.Add(this.label_order_by);
            this.groupBox_outros.Controls.Add(this.textBox_paginas);
            this.groupBox_outros.Controls.Add(this.label_paginas);
            this.groupBox_outros.Controls.Add(this.comboBox_order_by);
            this.groupBox_outros.Location = new System.Drawing.Point(129, 186);
            this.groupBox_outros.Name = "groupBox_outros";
            this.groupBox_outros.Size = new System.Drawing.Size(196, 81);
            this.groupBox_outros.TabIndex = 74;
            this.groupBox_outros.TabStop = false;
            this.groupBox_outros.Text = "outros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(333, 306);
            this.Controls.Add(this.groupBox_outros);
            this.Controls.Add(this.linkLabel_sobre);
            this.Controls.Add(this.groupBox_periodos);
            this.Controls.Add(this.button_console);
            this.Controls.Add(this.textBox_resultado_nome_arquivos);
            this.Controls.Add(this.groupBox_ondeProcurar);
            this.Controls.Add(this.groupBox_funcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coub Mass Download";
            this.groupBox_periodos.ResumeLayout(false);
            this.groupBox_periodos.PerformLayout();
            this.groupBox_ondeProcurar.ResumeLayout(false);
            this.groupBox_ondeProcurar.PerformLayout();
            this.groupBox_funcoes.ResumeLayout(false);
            this.groupBox_outros.ResumeLayout(false);
            this.groupBox_outros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_resultado_nome_arquivos;
        private System.Windows.Forms.Button Botao_TUDO;
        private System.Windows.Forms.Button button_pegar_links;
        private System.Windows.Forms.Button button_nomes_arquivos;
        private System.Windows.Forms.Button button_baixar_coub;
        private System.Windows.Forms.Button button_unir_videos;
        private System.Windows.Forms.Button button_apagar_arquivos;
        private System.Windows.Forms.RadioButton radioButton_daily;
        private System.Windows.Forms.RadioButton radioButton_weekly;
        private System.Windows.Forms.RadioButton radioButton_quarter;
        private System.Windows.Forms.RadioButton radioButton_monthly;
        private System.Windows.Forms.RadioButton radioButton_half;
        private System.Windows.Forms.TextBox textBox_comunidade;
        private System.Windows.Forms.TextBox textBox_paginas;
        private System.Windows.Forms.Label label_paginas;
        private System.Windows.Forms.GroupBox groupBox_periodos;
        private System.Windows.Forms.GroupBox groupBox_ondeProcurar;
        private System.Windows.Forms.Button button_ver_num_comunidades;
        private System.Windows.Forms.TextBox textBox_pesquisar;
        private System.Windows.Forms.RadioButton radioButton_pesquisar;
        private System.Windows.Forms.RadioButton radioButton_comunidade;
        private System.Windows.Forms.RadioButton radioButton_subscriptions;
        private System.Windows.Forms.GroupBox groupBox_funcoes;
        private System.Windows.Forms.ComboBox comboBox_order_by;
        private System.Windows.Forms.Label label_order_by;
        private System.Windows.Forms.Button button_copiar_intro_fim;
        private System.Windows.Forms.Button button_console;
        private System.Windows.Forms.LinkLabel linkLabel_sobre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox_outros;
    }
}

