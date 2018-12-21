namespace laba_1
{
    partial class FormDepot
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
            this.groupBoxTakeTrain = new System.Windows.Forms.GroupBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakeTrain = new System.Windows.Forms.Button();
            this.pictureBoxTakeTrain = new System.Windows.Forms.PictureBox();
            this.labelNumberPlace = new System.Windows.Forms.Label();
            this.pictureBoxDepot = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonSetTrain = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            this.groupBoxTakeTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTakeTrain
            // 
            this.groupBoxTakeTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTakeTrain.Controls.Add(this.maskedTextBox);
            this.groupBoxTakeTrain.Controls.Add(this.buttonTakeTrain);
            this.groupBoxTakeTrain.Controls.Add(this.pictureBoxTakeTrain);
            this.groupBoxTakeTrain.Controls.Add(this.labelNumberPlace);
            this.groupBoxTakeTrain.Location = new System.Drawing.Point(854, 299);
            this.groupBoxTakeTrain.Name = "groupBoxTakeTrain";
            this.groupBoxTakeTrain.Size = new System.Drawing.Size(192, 184);
            this.groupBoxTakeTrain.TabIndex = 3;
            this.groupBoxTakeTrain.TabStop = false;
            this.groupBoxTakeTrain.Text = "Забрать состав";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(60, 19);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBox.TabIndex = 3;
            this.maskedTextBox.ValidatingType = typeof(int);
            // 
            // buttonTakeTrain
            // 
            this.buttonTakeTrain.Location = new System.Drawing.Point(18, 54);
            this.buttonTakeTrain.Name = "buttonTakeTrain";
            this.buttonTakeTrain.Size = new System.Drawing.Size(160, 23);
            this.buttonTakeTrain.TabIndex = 2;
            this.buttonTakeTrain.Text = "Забрать состав";
            this.buttonTakeTrain.UseVisualStyleBackColor = true;
            this.buttonTakeTrain.Click += new System.EventHandler(this.buttonTakeTrain_Click);
            // 
            // pictureBoxTakeTrain
            // 
            this.pictureBoxTakeTrain.Location = new System.Drawing.Point(18, 83);
            this.pictureBoxTakeTrain.Name = "pictureBoxTakeTrain";
            this.pictureBoxTakeTrain.Size = new System.Drawing.Size(160, 95);
            this.pictureBoxTakeTrain.TabIndex = 1;
            this.pictureBoxTakeTrain.TabStop = false;
            // 
            // labelNumberPlace
            // 
            this.labelNumberPlace.AutoSize = true;
            this.labelNumberPlace.Location = new System.Drawing.Point(15, 22);
            this.labelNumberPlace.Name = "labelNumberPlace";
            this.labelNumberPlace.Size = new System.Drawing.Size(39, 13);
            this.labelNumberPlace.TabIndex = 0;
            this.labelNumberPlace.Text = "Место";
            // 
            // pictureBoxDepot
            // 
            this.pictureBoxDepot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDepot.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxDepot.Name = "pictureBoxDepot";
            this.pictureBoxDepot.Size = new System.Drawing.Size(1058, 468);
            this.pictureBoxDepot.TabIndex = 0;
            this.pictureBoxDepot.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(854, 12);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(192, 121);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // buttonSetTrain
            // 
            this.buttonSetTrain.Location = new System.Drawing.Point(854, 139);
            this.buttonSetTrain.Name = "buttonSetTrain";
            this.buttonSetTrain.Size = new System.Drawing.Size(192, 65);
            this.buttonSetTrain.TabIndex = 5;
            this.buttonSetTrain.Text = "Добавить состав";
            this.buttonSetTrain.UseVisualStyleBackColor = true;
            this.buttonSetTrain.Click += new System.EventHandler(this.buttonSetTrain_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1058, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(854, 210);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(192, 65);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 492);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonSetTrain);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBoxTakeTrain);
            this.Controls.Add(this.pictureBoxDepot);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormDepot";
            this.Text = "Депо";
            this.groupBoxTakeTrain.ResumeLayout(false);
            this.groupBoxTakeTrain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepot;
        private System.Windows.Forms.GroupBox groupBoxTakeTrain;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button buttonTakeTrain;
        private System.Windows.Forms.PictureBox pictureBoxTakeTrain;
        private System.Windows.Forms.Label labelNumberPlace;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonSetTrain;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}