namespace Juego_Cliente
{
    partial class Form2
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
            this.btnBasta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFlor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBasta
            // 
            this.btnBasta.BackColor = System.Drawing.Color.Red;
            this.btnBasta.ForeColor = System.Drawing.Color.White;
            this.btnBasta.Location = new System.Drawing.Point(358, 407);
            this.btnBasta.Name = "btnBasta";
            this.btnBasta.Size = new System.Drawing.Size(75, 23);
            this.btnBasta.TabIndex = 15;
            this.btnBasta.Text = "BASTA";
            this.btnBasta.UseVisualStyleBackColor = false;
            this.btnBasta.Click += new System.EventHandler(this.btnBasta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(386, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(716, 23);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.ReadOnly = true;
            this.txtLetra.Size = new System.Drawing.Size(35, 20);
            this.txtLetra.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNombre,
            this.clApellido,
            this.clCiudad,
            this.clFlor,
            this.clAnimal,
            this.clColor,
            this.clCosa});
            this.dataGridView1.Location = new System.Drawing.Point(47, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(707, 332);
            this.dataGridView1.TabIndex = 8;
            // 
            // clNombre
            // 
            this.clNombre.HeaderText = "Nombre";
            this.clNombre.Name = "clNombre";
            // 
            // clApellido
            // 
            this.clApellido.HeaderText = "Apellido";
            this.clApellido.Name = "clApellido";
            // 
            // clCiudad
            // 
            this.clCiudad.HeaderText = "Ciudad o Pais";
            this.clCiudad.Name = "clCiudad";
            // 
            // clFlor
            // 
            this.clFlor.HeaderText = "Flor o Fruto";
            this.clFlor.Name = "clFlor";
            // 
            // clAnimal
            // 
            this.clAnimal.HeaderText = "Animal";
            this.clAnimal.Name = "clAnimal";
            // 
            // clColor
            // 
            this.clColor.HeaderText = "Color";
            this.clColor.Name = "clColor";
            // 
            // clCosa
            // 
            this.clCosa.HeaderText = "Cosa";
            this.clCosa.Name = "clCosa";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBasta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasta;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFlor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCosa;
    }
}