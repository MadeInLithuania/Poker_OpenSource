namespace Poker
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.TableLayoutPanel();
            this.lblArriere = new System.Windows.Forms.Label();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.titre.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.MinimumSize = new System.Drawing.Size(100, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paramètres";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.BackColor = System.Drawing.Color.Transparent;
            this.titre.ColumnCount = 1;
            this.titre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.titre.Controls.Add(this.label1, 0, 0);
            this.titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.titre.Location = new System.Drawing.Point(0, 0);
            this.titre.Name = "titre";
            this.titre.RowCount = 1;
            this.titre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titre.Size = new System.Drawing.Size(1847, 100);
            this.titre.TabIndex = 1;
            // 
            // lblArriere
            // 
            this.lblArriere.AutoSize = true;
            this.lblArriere.BackColor = System.Drawing.Color.Transparent;
            this.lblArriere.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblArriere.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArriere.ForeColor = System.Drawing.Color.White;
            this.lblArriere.Location = new System.Drawing.Point(0, 100);
            this.lblArriere.Name = "lblArriere";
            this.lblArriere.Size = new System.Drawing.Size(449, 65);
            this.lblArriere.TabIndex = 2;
            this.lblArriere.Text = "<- Retour en arrière";
            this.lblArriere.Click += new System.EventHandler(this.lblArriere_Click);
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.BackColor = System.Drawing.Color.Transparent;
            this.btnAppliquer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppliquer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppliquer.ForeColor = System.Drawing.Color.Transparent;
            this.btnAppliquer.Location = new System.Drawing.Point(636, 783);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(725, 100);
            this.btnAppliquer.TabIndex = 3;
            this.btnAppliquer.Text = "Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(930, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Langue : ";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1847, 1026);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAppliquer);
            this.Controls.Add(this.lblArriere);
            this.Controls.Add(this.titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Paramètres";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.titre.ResumeLayout(false);
            this.titre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel titre;
        private System.Windows.Forms.Label lblArriere;
        private System.Windows.Forms.Button btnAppliquer;
        private System.Windows.Forms.Label label2;
    }
}