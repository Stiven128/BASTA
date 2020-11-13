namespace Juego
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFlor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.btnLetra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBasta = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(707, 332);
            this.dataGridView1.TabIndex = 0;
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
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(681, 43);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.ReadOnly = true;
            this.txtLetra.Size = new System.Drawing.Size(35, 20);
            this.txtLetra.TabIndex = 1;
            // 
            // btnLetra
            // 
            this.btnLetra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLetra.Location = new System.Drawing.Point(589, 40);
            this.btnLetra.Name = "btnLetra";
            this.btnLetra.Size = new System.Drawing.Size(75, 23);
            this.btnLetra.TabIndex = 2;
            this.btnLetra.Text = "Letra";
            this.btnLetra.UseVisualStyleBackColor = false;
            this.btnLetra.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(29, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(351, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // btnBasta
            // 
            this.btnBasta.BackColor = System.Drawing.Color.Red;
            this.btnBasta.ForeColor = System.Drawing.Color.White;
            this.btnBasta.Location = new System.Drawing.Point(323, 427);
            this.btnBasta.Name = "btnBasta";
            this.btnBasta.Size = new System.Drawing.Size(75, 23);
            this.btnBasta.TabIndex = 7;
            this.btnBasta.Text = "BASTA";
            this.btnBasta.UseVisualStyleBackColor = false;
            this.btnBasta.Click += new System.EventHandler(this.btnBasta_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(641, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(733, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBasta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLetra);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego Servidor";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnLetra;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBasta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFlor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCosa;
        private System.Windows.Forms.Button button1;
    }
}