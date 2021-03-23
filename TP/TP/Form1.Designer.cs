
namespace TP
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVille = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnModification = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.Label();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClient,
            this.nomClient,
            this.prenomClient,
            this.datenaissClient,
            this.nomVille,
            this.btnModification});
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 306);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // idClient
            // 
            this.idClient.DataPropertyName = "id";
            this.idClient.HeaderText = "idClient";
            this.idClient.Name = "idClient";
            // 
            // nomClient
            // 
            this.nomClient.DataPropertyName = "nom";
            this.nomClient.HeaderText = "nomClient";
            this.nomClient.Name = "nomClient";
            // 
            // prenomClient
            // 
            this.prenomClient.DataPropertyName = "prenom";
            this.prenomClient.HeaderText = "prenomClient";
            this.prenomClient.Name = "prenomClient";
            // 
            // datenaissClient
            // 
            this.datenaissClient.DataPropertyName = "datenaiss";
            this.datenaissClient.HeaderText = "datenaissClient";
            this.datenaissClient.Name = "datenaissClient";
            // 
            // nomVille
            // 
            this.nomVille.DataPropertyName = "idVille";
            this.nomVille.HeaderText = "nomVille";
            this.nomVille.Name = "nomVille";
            // 
            // btnModification
            // 
            this.btnModification.DataPropertyName = "Modifier";
            this.btnModification.HeaderText = "Modifier";
            this.btnModification.Name = "btnModification";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DE DATAGRID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Location = new System.Drawing.Point(51, 378);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(35, 13);
            this.txtLabel.TabIndex = 2;
            this.txtLabel.Text = "label2";
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(547, 23);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVille.TabIndex = 3;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(692, 20);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnAfficher.TabIndex = 4;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 403);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissClient;
        private System.Windows.Forms.DataGridViewComboBoxColumn nomVille;
        private System.Windows.Forms.DataGridViewButtonColumn btnModification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.Button btnAfficher;
    }
}

