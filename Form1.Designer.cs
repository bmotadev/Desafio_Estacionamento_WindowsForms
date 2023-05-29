namespace Desafio_Estacionamento_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            grouBoxInformacoes = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            listBoxSaidaVeiculos = new ListBox();
            listBoxVeiculosAtivos = new ListBox();
            groupBox3 = new GroupBox();
            grouBoxInformacoes.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Informe a Placa";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Informe o Modelo";
            // 
            // grouBoxInformacoes
            // 
            grouBoxInformacoes.Controls.Add(groupBox3);
            grouBoxInformacoes.Controls.Add(textBox2);
            grouBoxInformacoes.Controls.Add(textBox1);
            grouBoxInformacoes.Controls.Add(button2);
            grouBoxInformacoes.Controls.Add(button1);
            grouBoxInformacoes.Controls.Add(label1);
            grouBoxInformacoes.Controls.Add(label2);
            grouBoxInformacoes.Location = new Point(12, 12);
            grouBoxInformacoes.Name = "grouBoxInformacoes";
            grouBoxInformacoes.Size = new Size(496, 240);
            grouBoxInformacoes.TabIndex = 2;
            grouBoxInformacoes.TabStop = false;
            grouBoxInformacoes.Text = "Informações do Veículo";
            grouBoxInformacoes.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(17, 188);
            button1.Name = "button1";
            button1.Size = new Size(196, 35);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(252, 188);
            button2.Name = "button2";
            button2.Size = new Size(221, 35);
            button2.TabIndex = 3;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 29);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 4;
            label3.Text = "Tempo de Permenência";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 63);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 5;
            label4.Text = "Total à Pagar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxVeiculosAtivos);
            groupBox1.Location = new Point(570, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 646);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Veículos no Estacionamento";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxSaidaVeiculos);
            groupBox2.Location = new Point(12, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 386);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Veículos que Saíram";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(124, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(154, 60);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(124, 23);
            textBox4.TabIndex = 9;
            // 
            // listBoxSaidaVeiculos
            // 
            listBoxSaidaVeiculos.FormattingEnabled = true;
            listBoxSaidaVeiculos.ItemHeight = 15;
            listBoxSaidaVeiculos.Location = new Point(17, 35);
            listBoxSaidaVeiculos.Name = "listBoxSaidaVeiculos";
            listBoxSaidaVeiculos.Size = new Size(456, 319);
            listBoxSaidaVeiculos.TabIndex = 0;
            // 
            // listBoxVeiculosAtivos
            // 
            listBoxVeiculosAtivos.FormattingEnabled = true;
            listBoxVeiculosAtivos.ItemHeight = 15;
            listBoxVeiculosAtivos.Location = new Point(20, 26);
            listBoxVeiculosAtivos.Name = "listBoxVeiculosAtivos";
            listBoxVeiculosAtivos.Size = new Size(461, 589);
            listBoxVeiculosAtivos.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(17, 89);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(456, 93);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 692);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grouBoxInformacoes);
            Name = "Form1";
            Text = "EstacioneiAqui";
            grouBoxInformacoes.ResumeLayout(false);
            grouBoxInformacoes.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox grouBoxInformacoes;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBoxVeiculosAtivos;
        private ListBox listBoxSaidaVeiculos;
    }
}