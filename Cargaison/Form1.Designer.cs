
namespace CargaisonForm
{
    partial class distance
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
            this.text_distance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.list_cargaison = new System.Windows.Forms.ListBox();
            this.btn_cargaison = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.TextBox();
            this.poids = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_marchandise = new System.Windows.Forms.Button();
            this.list_marchandise = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.list_marchandise)).BeginInit();
            this.SuspendLayout();
            // 
            // text_distance
            // 
            this.text_distance.Location = new System.Drawing.Point(118, 43);
            this.text_distance.Name = "text_distance";
            this.text_distance.Size = new System.Drawing.Size(182, 31);
            this.text_distance.TabIndex = 0;
            this.text_distance.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(33, 109);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(49, 25);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Type";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Aérienne",
            "Routiére"});
            this.type.Location = new System.Drawing.Point(118, 101);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(182, 33);
            this.type.TabIndex = 4;
            // 
            // list_cargaison
            // 
            this.list_cargaison.FormattingEnabled = true;
            this.list_cargaison.ItemHeight = 25;
            this.list_cargaison.Location = new System.Drawing.Point(20, 201);
            this.list_cargaison.Name = "list_cargaison";
            this.list_cargaison.Size = new System.Drawing.Size(410, 254);
            this.list_cargaison.TabIndex = 5;
            // 
            // btn_cargaison
            // 
            this.btn_cargaison.Location = new System.Drawing.Point(118, 152);
            this.btn_cargaison.Name = "btn_cargaison";
            this.btn_cargaison.Size = new System.Drawing.Size(112, 34);
            this.btn_cargaison.TabIndex = 6;
            this.btn_cargaison.Text = "Ajouter";
            this.btn_cargaison.UseVisualStyleBackColor = true;
            this.btn_cargaison.Click += new System.EventHandler(this.btn_cargaison_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Volume";
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(471, 152);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(150, 31);
            this.volume.TabIndex = 8;
            // 
            // poids
            // 
            this.poids.Location = new System.Drawing.Point(650, 152);
            this.poids.Name = "poids";
            this.poids.Size = new System.Drawing.Size(150, 31);
            this.poids.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Poids";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 11;
            // 
            // btn_marchandise
            // 
            this.btn_marchandise.Location = new System.Drawing.Point(833, 152);
            this.btn_marchandise.Name = "btn_marchandise";
            this.btn_marchandise.Size = new System.Drawing.Size(112, 34);
            this.btn_marchandise.TabIndex = 12;
            this.btn_marchandise.Text = "Ajouter";
            this.btn_marchandise.UseVisualStyleBackColor = true;
            // 
            // list_marchandise
            // 
            this.list_marchandise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_marchandise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.list_marchandise.Location = new System.Drawing.Point(471, 201);
            this.list_marchandise.Name = "list_marchandise";
            this.list_marchandise.RowHeadersWidth = 62;
            this.list_marchandise.RowTemplate.Height = 33;
            this.list_marchandise.Size = new System.Drawing.Size(490, 225);
            this.list_marchandise.TabIndex = 13;
            this.list_marchandise.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_marchandise_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 8;
            this.Numero.Name = "Numero";
            this.Numero.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Poids";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Volume";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // distance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 670);
            this.Controls.Add(this.list_marchandise);
            this.Controls.Add(this.btn_marchandise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.poids);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cargaison);
            this.Controls.Add(this.list_cargaison);
            this.Controls.Add(this.type);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_distance);
            this.Name = "distance";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_marchandise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_distance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ListBox list_cargaison;
        private System.Windows.Forms.Button btn_cargaison;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.TextBox poids;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_marchandise;
        private System.Windows.Forms.DataGridView list_marchandise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

