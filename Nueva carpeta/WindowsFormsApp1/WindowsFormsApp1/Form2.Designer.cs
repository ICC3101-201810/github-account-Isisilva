namespace WindowsFormsApp1
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
            this.Peliculas = new System.Windows.Forms.Button();
            this.Actores = new System.Windows.Forms.Button();
            this.Directores = new System.Windows.Forms.Button();
            this.Productores = new System.Windows.Forms.Button();
            this.Estudios = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Peliculas
            // 
            this.Peliculas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Peliculas.FlatAppearance.BorderSize = 0;
            this.Peliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peliculas.Location = new System.Drawing.Point(12, 145);
            this.Peliculas.Name = "Peliculas";
            this.Peliculas.Size = new System.Drawing.Size(75, 23);
            this.Peliculas.TabIndex = 0;
            this.Peliculas.Text = "Peliculas";
            this.Peliculas.UseVisualStyleBackColor = true;
            this.Peliculas.Click += new System.EventHandler(this.Peliculas_Click);
            // 
            // Actores
            // 
            this.Actores.Location = new System.Drawing.Point(93, 145);
            this.Actores.Name = "Actores";
            this.Actores.Size = new System.Drawing.Size(75, 23);
            this.Actores.TabIndex = 1;
            this.Actores.Text = "Actores";
            this.Actores.UseVisualStyleBackColor = true;
            this.Actores.Click += new System.EventHandler(this.Actores_Click);
            // 
            // Directores
            // 
            this.Directores.Location = new System.Drawing.Point(174, 145);
            this.Directores.Name = "Directores";
            this.Directores.Size = new System.Drawing.Size(75, 23);
            this.Directores.TabIndex = 2;
            this.Directores.Text = "Directores";
            this.Directores.UseVisualStyleBackColor = true;
            this.Directores.Click += new System.EventHandler(this.Directores_Click);
            // 
            // Productores
            // 
            this.Productores.Location = new System.Drawing.Point(255, 145);
            this.Productores.Name = "Productores";
            this.Productores.Size = new System.Drawing.Size(75, 23);
            this.Productores.TabIndex = 3;
            this.Productores.Text = "Productores";
            this.Productores.UseVisualStyleBackColor = true;
            this.Productores.Click += new System.EventHandler(this.Productores_Click);
            // 
            // Estudios
            // 
            this.Estudios.Location = new System.Drawing.Point(336, 145);
            this.Estudios.Name = "Estudios";
            this.Estudios.Size = new System.Drawing.Size(75, 23);
            this.Estudios.TabIndex = 4;
            this.Estudios.Text = "Estudios";
            this.Estudios.UseVisualStyleBackColor = true;
            this.Estudios.Click += new System.EventHandler(this.Estudios_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.productoresBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(365, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // productoresBindingSource
            // 
            this.productoresBindingSource.DataSource = typeof(WindowsFormsApp1.Productores);
            this.productoresBindingSource.CurrentChanged += new System.EventHandler(this.productoresBindingSource_CurrentChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 183);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Estudios);
            this.Controls.Add(this.Productores);
            this.Controls.Add(this.Directores);
            this.Controls.Add(this.Actores);
            this.Controls.Add(this.Peliculas);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.productoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Peliculas;
        private System.Windows.Forms.Button Actores;
        private System.Windows.Forms.Button Directores;
        private System.Windows.Forms.Button Productores;
        private System.Windows.Forms.Button Estudios;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource productoresBindingSource;
    }
}