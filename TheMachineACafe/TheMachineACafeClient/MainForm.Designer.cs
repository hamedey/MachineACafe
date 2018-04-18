namespace TheMachineACafeClient
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelNumBadge = new System.Windows.Forms.Label();
            this.textNumBadge = new System.Windows.Forms.TextBox();
            this.panelMachine = new System.Windows.Forms.Panel();
            this.buttonPrepareCafe = new System.Windows.Forms.Button();
            this.labelUseMug = new System.Windows.Forms.Label();
            this.labelVolumeSucre = new System.Windows.Forms.Label();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.labelQteSucre = new System.Windows.Forms.Label();
            this.comboBoxTypeBoisson = new System.Windows.Forms.ComboBox();
            this.labelTypeBoisson = new System.Windows.Forms.Label();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBoxCafe = new System.Windows.Forms.PictureBox();
            this.checkBoxUserMug = new System.Windows.Forms.CheckBox();
            this.panelMachine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumBadge
            // 
            this.labelNumBadge.AutoSize = true;
            this.labelNumBadge.Location = new System.Drawing.Point(149, 28);
            this.labelNumBadge.Name = "labelNumBadge";
            this.labelNumBadge.Size = new System.Drawing.Size(93, 13);
            this.labelNumBadge.TabIndex = 0;
            this.labelNumBadge.Text = "Numéro de Badge";
            // 
            // textNumBadge
            // 
            this.textNumBadge.Location = new System.Drawing.Point(259, 25);
            this.textNumBadge.Name = "textNumBadge";
            this.textNumBadge.Size = new System.Drawing.Size(134, 20);
            this.textNumBadge.TabIndex = 1;
            // 
            // panelMachine
            // 
            this.panelMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMachine.Controls.Add(this.checkBoxUserMug);
            this.panelMachine.Controls.Add(this.buttonPrepareCafe);
            this.panelMachine.Controls.Add(this.labelUseMug);
            this.panelMachine.Controls.Add(this.labelVolumeSucre);
            this.panelMachine.Controls.Add(this.buttonDown);
            this.panelMachine.Controls.Add(this.buttonUp);
            this.panelMachine.Controls.Add(this.labelQteSucre);
            this.panelMachine.Controls.Add(this.comboBoxTypeBoisson);
            this.panelMachine.Controls.Add(this.labelTypeBoisson);
            this.panelMachine.Enabled = false;
            this.panelMachine.Location = new System.Drawing.Point(58, 126);
            this.panelMachine.Name = "panelMachine";
            this.panelMachine.Size = new System.Drawing.Size(402, 285);
            this.panelMachine.TabIndex = 2;
            // 
            // buttonPrepareCafe
            // 
            this.buttonPrepareCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrepareCafe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPrepareCafe.Location = new System.Drawing.Point(271, 236);
            this.buttonPrepareCafe.Name = "buttonPrepareCafe";
            this.buttonPrepareCafe.Size = new System.Drawing.Size(110, 35);
            this.buttonPrepareCafe.TabIndex = 14;
            this.buttonPrepareCafe.Text = "Valider";
            this.buttonPrepareCafe.UseVisualStyleBackColor = true;
            this.buttonPrepareCafe.Click += new System.EventHandler(this.buttonPrepareCafe_Click);
            // 
            // labelUseMug
            // 
            this.labelUseMug.AutoSize = true;
            this.labelUseMug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUseMug.Location = new System.Drawing.Point(7, 200);
            this.labelUseMug.Name = "labelUseMug";
            this.labelUseMug.Size = new System.Drawing.Size(212, 17);
            this.labelUseMug.TabIndex = 12;
            this.labelUseMug.Text = "Voulez-vous utilisez votre mug ?";
            // 
            // labelVolumeSucre
            // 
            this.labelVolumeSucre.AutoSize = true;
            this.labelVolumeSucre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVolumeSucre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumeSucre.Location = new System.Drawing.Point(328, 129);
            this.labelVolumeSucre.Name = "labelVolumeSucre";
            this.labelVolumeSucre.Size = new System.Drawing.Size(18, 19);
            this.labelVolumeSucre.TabIndex = 10;
            this.labelVolumeSucre.Text = "0";
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.Location = new System.Drawing.Point(22, 119);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(60, 29);
            this.buttonDown.TabIndex = 9;
            this.buttonDown.Text = "-";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(102, 119);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(60, 29);
            this.buttonUp.TabIndex = 8;
            this.buttonUp.Text = "+";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // labelQteSucre
            // 
            this.labelQteSucre.AutoSize = true;
            this.labelQteSucre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQteSucre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQteSucre.Location = new System.Drawing.Point(188, 129);
            this.labelQteSucre.Name = "labelQteSucre";
            this.labelQteSucre.Size = new System.Drawing.Size(123, 19);
            this.labelQteSucre.TabIndex = 7;
            this.labelQteSucre.Text = "Quantité de sucre";
            // 
            // comboBoxTypeBoisson
            // 
            this.comboBoxTypeBoisson.FormattingEnabled = true;
            this.comboBoxTypeBoisson.Location = new System.Drawing.Point(152, 46);
            this.comboBoxTypeBoisson.Name = "comboBoxTypeBoisson";
            this.comboBoxTypeBoisson.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeBoisson.TabIndex = 6;
            // 
            // labelTypeBoisson
            // 
            this.labelTypeBoisson.AutoSize = true;
            this.labelTypeBoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeBoisson.Location = new System.Drawing.Point(28, 49);
            this.labelTypeBoisson.Name = "labelTypeBoisson";
            this.labelTypeBoisson.Size = new System.Drawing.Size(113, 17);
            this.labelTypeBoisson.TabIndex = 5;
            this.labelTypeBoisson.Text = "Type de boisson";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(210, 72);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(74, 36);
            this.buttonValidate.TabIndex = 3;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(366, 72);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(74, 36);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCafe
            // 
            this.pictureBoxCafe.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCafe.Image")));
            this.pictureBoxCafe.Location = new System.Drawing.Point(492, 184);
            this.pictureBoxCafe.Name = "pictureBoxCafe";
            this.pictureBoxCafe.Size = new System.Drawing.Size(269, 227);
            this.pictureBoxCafe.TabIndex = 6;
            this.pictureBoxCafe.TabStop = false;
            this.pictureBoxCafe.Visible = false;
            // 
            // checkBoxUserMug
            // 
            this.checkBoxUserMug.AutoSize = true;
            this.checkBoxUserMug.Location = new System.Drawing.Point(231, 201);
            this.checkBoxUserMug.Name = "checkBoxUserMug";
            this.checkBoxUserMug.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUserMug.TabIndex = 15;
            this.checkBoxUserMug.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 462);
            this.Controls.Add(this.pictureBoxCafe);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.panelMachine);
            this.Controls.Add(this.textNumBadge);
            this.Controls.Add(this.labelNumBadge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Machine à café";
            this.panelMachine.ResumeLayout(false);
            this.panelMachine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumBadge;
        private System.Windows.Forms.TextBox textNumBadge;
        private System.Windows.Forms.Panel panelMachine;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTypeBoisson;
        private System.Windows.Forms.ComboBox comboBoxTypeBoisson;
        private System.Windows.Forms.Label labelQteSucre;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label labelVolumeSucre;
        private System.Windows.Forms.Label labelUseMug;
        private System.Windows.Forms.Button buttonPrepareCafe;
        private System.Windows.Forms.PictureBox pictureBoxCafe;
        private System.Windows.Forms.CheckBox checkBoxUserMug;
    }
}

