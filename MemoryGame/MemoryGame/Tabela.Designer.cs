using System.ComponentModel;

namespace MemoryGame
{
    partial class Tabela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.scoreBox = new System.Windows.Forms.ListBox();
            this.delScoreBox = new System.Windows.Forms.Button();
            this.menuTab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreBox
            // 
            this.scoreBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.scoreBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.scoreBox.FormattingEnabled = true;
            this.scoreBox.ItemHeight = 30;
            this.scoreBox.Location = new System.Drawing.Point(12, 33);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(310, 334);
            this.scoreBox.TabIndex = 0;
            // 
            // delScoreBox
            // 
            this.delScoreBox.Location = new System.Drawing.Point(220, 399);
            this.delScoreBox.Name = "delScoreBox";
            this.delScoreBox.Size = new System.Drawing.Size(101, 31);
            this.delScoreBox.TabIndex = 2;
            this.delScoreBox.Text = "Usuń";
            this.delScoreBox.UseVisualStyleBackColor = true;
            this.delScoreBox.Click += new System.EventHandler(this.del_Click);
            // 
            // menuTab
            // 
            this.menuTab.Location = new System.Drawing.Point(12, 399);
            this.menuTab.Name = "menuTab";
            this.menuTab.Size = new System.Drawing.Size(101, 31);
            this.menuTab.TabIndex = 3;
            this.menuTab.Text = "Menu";
            this.menuTab.UseVisualStyleBackColor = true;
            this.menuTab.Click += new System.EventHandler(this.menuTab_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wyniki:";
            // 
            // Tabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(334, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuTab);
            this.Controls.Add(this.delScoreBox);
            this.Controls.Add(this.scoreBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Tabela";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela Wyników";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox scoreBox;
        private System.Windows.Forms.Button delScoreBox;
        private System.Windows.Forms.Button menuTab;
        private System.Windows.Forms.Label label1;
    }
}