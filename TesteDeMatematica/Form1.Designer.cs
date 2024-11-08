namespace TesteDeMatematica
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
            components = new System.ComponentModel.Container();
            TimeLbl = new Label();
            label1 = new Label();
            EsquerdaLbl = new Label();
            label2 = new Label();
            DireitaLbl = new Label();
            label3 = new Label();
            Soma = new NumericUpDown();
            Diferenca = new NumericUpDown();
            label4 = new Label();
            MenosDireitaLbl = new Label();
            label6 = new Label();
            MenosEsquerdaLbl = new Label();
            Produto = new NumericUpDown();
            label8 = new Label();
            VezesDireitaLbl = new Label();
            label10 = new Label();
            VezesEsquerdaLbl = new Label();
            Quonsciente = new NumericUpDown();
            label12 = new Label();
            DivisaoDireitaLbl = new Label();
            label14 = new Label();
            DivisaoEsquerdaLbl = new Label();
            StartBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Soma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Diferenca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Produto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Quonsciente).BeginInit();
            SuspendLayout();
            // 
            // TimeLbl
            // 
            TimeLbl.BorderStyle = BorderStyle.FixedSingle;
            TimeLbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeLbl.Location = new Point(272, 9);
            TimeLbl.Name = "TimeLbl";
            TimeLbl.Size = new Size(200, 30);
            TimeLbl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 1;
            label1.Text = "Tempo restante";
            // 
            // EsquerdaLbl
            // 
            EsquerdaLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EsquerdaLbl.Location = new Point(24, 70);
            EsquerdaLbl.Name = "EsquerdaLbl";
            EsquerdaLbl.Size = new Size(60, 50);
            EsquerdaLbl.TabIndex = 2;
            EsquerdaLbl.Text = "?";
            EsquerdaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 70);
            label2.Name = "label2";
            label2.Size = new Size(60, 50);
            label2.TabIndex = 3;
            label2.Text = "+";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DireitaLbl
            // 
            DireitaLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DireitaLbl.Location = new Point(165, 70);
            DireitaLbl.Name = "DireitaLbl";
            DireitaLbl.Size = new Size(60, 50);
            DireitaLbl.TabIndex = 4;
            DireitaLbl.Text = "?";
            DireitaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(231, 70);
            label3.Name = "label3";
            label3.Size = new Size(66, 50);
            label3.TabIndex = 5;
            label3.Text = "=";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Soma
            // 
            Soma.Font = new Font("Segoe UI", 18F);
            Soma.Location = new Point(303, 81);
            Soma.Name = "Soma";
            Soma.Size = new Size(100, 39);
            Soma.TabIndex = 1;
            // 
            // Diferenca
            // 
            Diferenca.Font = new Font("Segoe UI", 18F);
            Diferenca.Location = new Point(303, 134);
            Diferenca.Name = "Diferenca";
            Diferenca.Size = new Size(100, 39);
            Diferenca.TabIndex = 2;
            Diferenca.ValueChanged += Diferenca_ValueChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(231, 123);
            label4.Name = "label4";
            label4.Size = new Size(66, 50);
            label4.TabIndex = 10;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenosDireitaLbl
            // 
            MenosDireitaLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenosDireitaLbl.Location = new Point(165, 123);
            MenosDireitaLbl.Name = "MenosDireitaLbl";
            MenosDireitaLbl.Size = new Size(60, 50);
            MenosDireitaLbl.TabIndex = 9;
            MenosDireitaLbl.Text = "?";
            MenosDireitaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(99, 123);
            label6.Name = "label6";
            label6.Size = new Size(60, 50);
            label6.TabIndex = 8;
            label6.Text = "-";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenosEsquerdaLbl
            // 
            MenosEsquerdaLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenosEsquerdaLbl.Location = new Point(24, 123);
            MenosEsquerdaLbl.Name = "MenosEsquerdaLbl";
            MenosEsquerdaLbl.Size = new Size(60, 50);
            MenosEsquerdaLbl.TabIndex = 7;
            MenosEsquerdaLbl.Text = "?";
            MenosEsquerdaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Produto
            // 
            Produto.Font = new Font("Segoe UI", 18F);
            Produto.Location = new Point(303, 184);
            Produto.Name = "Produto";
            Produto.Size = new Size(100, 39);
            Produto.TabIndex = 3;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(231, 173);
            label8.Name = "label8";
            label8.Size = new Size(66, 50);
            label8.TabIndex = 15;
            label8.Text = "=";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VezesDireitaLbl
            // 
            VezesDireitaLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VezesDireitaLbl.Location = new Point(165, 173);
            VezesDireitaLbl.Name = "VezesDireitaLbl";
            VezesDireitaLbl.Size = new Size(60, 50);
            VezesDireitaLbl.TabIndex = 14;
            VezesDireitaLbl.Text = "?";
            VezesDireitaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(99, 173);
            label10.Name = "label10";
            label10.Size = new Size(60, 50);
            label10.TabIndex = 13;
            label10.Text = "x";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VezesEsquerdaLbl
            // 
            VezesEsquerdaLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VezesEsquerdaLbl.Location = new Point(24, 173);
            VezesEsquerdaLbl.Name = "VezesEsquerdaLbl";
            VezesEsquerdaLbl.Size = new Size(60, 50);
            VezesEsquerdaLbl.TabIndex = 12;
            VezesEsquerdaLbl.Text = "?";
            VezesEsquerdaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Quonsciente
            // 
            Quonsciente.Font = new Font("Segoe UI", 18F);
            Quonsciente.Location = new Point(303, 234);
            Quonsciente.Name = "Quonsciente";
            Quonsciente.Size = new Size(100, 39);
            Quonsciente.TabIndex = 4;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(231, 223);
            label12.Name = "label12";
            label12.Size = new Size(66, 50);
            label12.TabIndex = 20;
            label12.Text = "=";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DivisaoDireitaLbl
            // 
            DivisaoDireitaLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DivisaoDireitaLbl.Location = new Point(165, 223);
            DivisaoDireitaLbl.Name = "DivisaoDireitaLbl";
            DivisaoDireitaLbl.Size = new Size(60, 50);
            DivisaoDireitaLbl.TabIndex = 19;
            DivisaoDireitaLbl.Text = "?";
            DivisaoDireitaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(99, 223);
            label14.Name = "label14";
            label14.Size = new Size(60, 50);
            label14.TabIndex = 18;
            label14.Text = "/";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DivisaoEsquerdaLbl
            // 
            DivisaoEsquerdaLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DivisaoEsquerdaLbl.Location = new Point(24, 223);
            DivisaoEsquerdaLbl.Name = "DivisaoEsquerdaLbl";
            DivisaoEsquerdaLbl.Size = new Size(60, 50);
            DivisaoEsquerdaLbl.TabIndex = 17;
            DivisaoEsquerdaLbl.Text = "?";
            DivisaoEsquerdaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartBtn
            // 
            StartBtn.AutoSize = true;
            StartBtn.Font = new Font("Segoe UI", 14F);
            StartBtn.Location = new Point(191, 310);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(137, 35);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "Iniciar o Teste";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(StartBtn);
            Controls.Add(Quonsciente);
            Controls.Add(label12);
            Controls.Add(DivisaoDireitaLbl);
            Controls.Add(label14);
            Controls.Add(DivisaoEsquerdaLbl);
            Controls.Add(Produto);
            Controls.Add(label8);
            Controls.Add(VezesDireitaLbl);
            Controls.Add(label10);
            Controls.Add(VezesEsquerdaLbl);
            Controls.Add(Diferenca);
            Controls.Add(label4);
            Controls.Add(MenosDireitaLbl);
            Controls.Add(label6);
            Controls.Add(MenosEsquerdaLbl);
            Controls.Add(Soma);
            Controls.Add(label3);
            Controls.Add(DireitaLbl);
            Controls.Add(label2);
            Controls.Add(EsquerdaLbl);
            Controls.Add(label1);
            Controls.Add(TimeLbl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Teste de Matematica";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Soma).EndInit();
            ((System.ComponentModel.ISupportInitialize)Diferenca).EndInit();
            ((System.ComponentModel.ISupportInitialize)Produto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Quonsciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TimeLbl;
        private Label label1;
        private Label EsquerdaLbl;
        private Label label2;
        private Label DireitaLbl;
        private Label label3;
        private NumericUpDown Soma;
        private NumericUpDown Diferenca;
        private Label label4;
        private Label MenosDireitaLbl;
        private Label label6;
        private Label MenosEsquerdaLbl;
        private NumericUpDown Produto;
        private Label label8;
        private Label VezesDireitaLbl;
        private Label label10;
        private Label VezesEsquerdaLbl;
        private NumericUpDown Quonsciente;
        private Label label12;
        private Label DivisaoDireitaLbl;
        private Label label14;
        private Label DivisaoEsquerdaLbl;
        private Button StartBtn;
        private System.Windows.Forms.Timer timer1;
    }
}
