
namespace Ejercicio7
{
    partial class Menucajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Valortransferencia = new System.Windows.Forms.TextBox();
            this.CuentaTrasferencia = new System.Windows.Forms.TextBox();
            this.Trasnferencia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.valorretiro = new System.Windows.Forms.TextBox();
            this.Retirar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Consultasaldo = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Consultapuntos = new System.Windows.Forms.Button();
            this.redimepuntos = new System.Windows.Forms.Button();
            this.lblvalorretiro = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 397);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Valortransferencia);
            this.groupBox2.Controls.Add(this.CuentaTrasferencia);
            this.groupBox2.Controls.Add(this.Trasnferencia);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(240, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 133);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRANSFERENCIAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Valor Transferencia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Número Cuenta Destino:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Valortransferencia
            // 
            this.Valortransferencia.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valortransferencia.Location = new System.Drawing.Point(148, 54);
            this.Valortransferencia.Name = "Valortransferencia";
            this.Valortransferencia.Size = new System.Drawing.Size(160, 25);
            this.Valortransferencia.TabIndex = 11;
            // 
            // CuentaTrasferencia
            // 
            this.CuentaTrasferencia.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuentaTrasferencia.Location = new System.Drawing.Point(149, 24);
            this.CuentaTrasferencia.Name = "CuentaTrasferencia";
            this.CuentaTrasferencia.Size = new System.Drawing.Size(160, 25);
            this.CuentaTrasferencia.TabIndex = 10;
            this.CuentaTrasferencia.TextChanged += new System.EventHandler(this.CuentaTrasferencia_TextChanged);
            // 
            // Trasnferencia
            // 
            this.Trasnferencia.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trasnferencia.Location = new System.Drawing.Point(63, 84);
            this.Trasnferencia.Name = "Trasnferencia";
            this.Trasnferencia.Size = new System.Drawing.Size(157, 38);
            this.Trasnferencia.TabIndex = 9;
            this.Trasnferencia.Text = "Transferir";
            this.Trasnferencia.UseVisualStyleBackColor = true;
            this.Trasnferencia.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Controls.Add(this.lblvalorretiro);
            this.groupBox3.Controls.Add(this.valorretiro);
            this.groupBox3.Controls.Add(this.Retirar);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 133);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RETIROS";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // valorretiro
            // 
            this.valorretiro.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorretiro.Location = new System.Drawing.Point(6, 39);
            this.valorretiro.Name = "valorretiro";
            this.valorretiro.Size = new System.Drawing.Size(160, 25);
            this.valorretiro.TabIndex = 10;
            this.valorretiro.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Retirar
            // 
            this.Retirar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retirar.Location = new System.Drawing.Point(6, 84);
            this.Retirar.Name = "Retirar";
            this.Retirar.Size = new System.Drawing.Size(182, 43);
            this.Retirar.TabIndex = 9;
            this.Retirar.Text = "Retirar";
            this.Retirar.UseVisualStyleBackColor = true;
            this.Retirar.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(8, 256);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(550, 124);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Consultasaldo
            // 
            this.Consultasaldo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Consultasaldo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultasaldo.Location = new System.Drawing.Point(614, 24);
            this.Consultasaldo.Name = "Consultasaldo";
            this.Consultasaldo.Size = new System.Drawing.Size(182, 59);
            this.Consultasaldo.TabIndex = 10;
            this.Consultasaldo.Text = "Consultar Saldo";
            this.Consultasaldo.UseVisualStyleBackColor = true;
            this.Consultasaldo.Click += new System.EventHandler(this.button5_Click);
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(614, 226);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(182, 51);
            this.Salir.TabIndex = 16;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // Consultapuntos
            // 
            this.Consultapuntos.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultapuntos.Location = new System.Drawing.Point(614, 89);
            this.Consultapuntos.Name = "Consultapuntos";
            this.Consultapuntos.Size = new System.Drawing.Size(182, 59);
            this.Consultapuntos.TabIndex = 18;
            this.Consultapuntos.Text = "Consultar Puntos Vive Colombia";
            this.Consultapuntos.UseVisualStyleBackColor = true;
            this.Consultapuntos.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // redimepuntos
            // 
            this.redimepuntos.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redimepuntos.Location = new System.Drawing.Point(614, 157);
            this.redimepuntos.Name = "redimepuntos";
            this.redimepuntos.Size = new System.Drawing.Size(182, 51);
            this.redimepuntos.TabIndex = 19;
            this.redimepuntos.Text = "Redimir Puntos Vive Colombia";
            this.redimepuntos.UseVisualStyleBackColor = true;
            this.redimepuntos.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // lblvalorretiro
            // 
            this.lblvalorretiro.AutoSize = true;
            this.lblvalorretiro.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorretiro.Location = new System.Drawing.Point(6, 21);
            this.lblvalorretiro.Name = "lblvalorretiro";
            this.lblvalorretiro.Size = new System.Drawing.Size(169, 13);
            this.lblvalorretiro.TabIndex = 18;
            this.lblvalorretiro.Text = "Digite el valor del retiro:";
            // 
            // Menucajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 421);
            this.Controls.Add(this.redimepuntos);
            this.Controls.Add(this.Consultapuntos);
            this.Controls.Add(this.Consultasaldo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Salir);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menucajero";
            this.Text = "Cajero";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Consultasaldo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox valorretiro;
        private System.Windows.Forms.Button Retirar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Consultapuntos;
        private System.Windows.Forms.Button redimepuntos;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Valortransferencia;
        private System.Windows.Forms.TextBox CuentaTrasferencia;
        private System.Windows.Forms.Button Trasnferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblvalorretiro;
    }
}