namespace Eleve
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
            this.grpGroupe = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdDisplayGrp = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.lstGroupe = new System.Windows.Forms.ListBox();
            this.grpGroupe.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGroupe
            // 
            this.grpGroupe.Controls.Add(this.lstGroupe);
            this.grpGroupe.Location = new System.Drawing.Point(12, 13);
            this.grpGroupe.Name = "grpGroupe";
            this.grpGroupe.Size = new System.Drawing.Size(284, 436);
            this.grpGroupe.TabIndex = 0;
            this.grpGroupe.TabStop = false;
            this.grpGroupe.Text = "Groupe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdDisplayGrp);
            this.groupBox2.Controls.Add(this.cmdPrint);
            this.groupBox2.Controls.Add(this.cmdCreate);
            this.groupBox2.Location = new System.Drawing.Point(334, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 436);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // cmdDisplayGrp
            // 
            this.cmdDisplayGrp.Location = new System.Drawing.Point(38, 189);
            this.cmdDisplayGrp.Name = "cmdDisplayGrp";
            this.cmdDisplayGrp.Size = new System.Drawing.Size(117, 63);
            this.cmdDisplayGrp.TabIndex = 2;
            this.cmdDisplayGrp.Text = "Afficher les groupes";
            this.cmdDisplayGrp.UseVisualStyleBackColor = true;
            this.cmdDisplayGrp.Click += new System.EventHandler(this.cmdDisplayGrp_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(38, 258);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(117, 63);
            this.cmdPrint.TabIndex = 1;
            this.cmdPrint.Text = "Imprimer les groupes";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(38, 120);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(117, 63);
            this.cmdCreate.TabIndex = 0;
            this.cmdCreate.Text = "Créer un élève";
            this.cmdCreate.UseVisualStyleBackColor = true;
            // 
            // lstGroupe
            // 
            this.lstGroupe.FormattingEnabled = true;
            this.lstGroupe.Location = new System.Drawing.Point(7, 20);
            this.lstGroupe.Name = "lstGroupe";
            this.lstGroupe.Size = new System.Drawing.Size(271, 407);
            this.lstGroupe.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpGroupe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGroupe.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGroupe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdDisplayGrp;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.ListBox lstGroupe;
    }
}

