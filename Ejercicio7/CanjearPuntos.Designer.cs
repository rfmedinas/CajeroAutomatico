
namespace Ejercicio7
{
    partial class CanjearPuntos
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
            this.Redimir = new System.Windows.Forms.Button();
            this.numpuntos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Redimir
            // 
            this.Redimir.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Redimir.Location = new System.Drawing.Point(117, 68);
            this.Redimir.Name = "Redimir";
            this.Redimir.Size = new System.Drawing.Size(182, 51);
            this.Redimir.TabIndex = 27;
            this.Redimir.Text = "Redimir";
            this.Redimir.UseVisualStyleBackColor = true;
            this.Redimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // numpuntos
            // 
            this.numpuntos.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpuntos.Location = new System.Drawing.Point(260, 28);
            this.numpuntos.Name = "numpuntos";
            this.numpuntos.Size = new System.Drawing.Size(219, 25);
            this.numpuntos.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Número de Puntos a Redimir:";
            // 
            // CanjearPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 164);
            this.Controls.Add(this.Redimir);
            this.Controls.Add(this.numpuntos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CanjearPuntos";
            this.Text = "Canjear Puntos";
            this.Load += new System.EventHandler(this.CanjearPuntos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Redimir;
        private System.Windows.Forms.TextBox numpuntos;
        private System.Windows.Forms.Label label1;
    }
}