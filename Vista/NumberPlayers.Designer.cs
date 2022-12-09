namespace BlackJackCs.Vista
{
    partial class NumberPlayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public int numero { get; set; }
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
            this.Aceptar = new System.Windows.Forms.Button();
            this.NumberPlayerTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(98, 56);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 0;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // NumberPlayerTB
            // 
            this.NumberPlayerTB.Location = new System.Drawing.Point(12, 27);
            this.NumberPlayerTB.Name = "NumberPlayerTB";
            this.NumberPlayerTB.Size = new System.Drawing.Size(251, 23);
            this.NumberPlayerTB.TabIndex = 1;
            this.NumberPlayerTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberPlayerTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digete el numero de jugadores";
            // 
            // NumberPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 91);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberPlayerTB);
            this.Controls.Add(this.Aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NumberPlayers";
            this.Text = "NumberPlayers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Aceptar;
        private TextBox NumberPlayerTB;
        private Label label1;
    }
}