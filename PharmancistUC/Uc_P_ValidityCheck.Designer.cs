
namespace Pharmacy_Management_System.PharmancistUC
{
    partial class Uc_P_ValidityCheck
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.la = new System.Windows.Forms.Label();
            this.dgvValidityCheck = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCheck = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSet = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidityCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.Location = new System.Drawing.Point(33, 27);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(364, 36);
            this.la.TabIndex = 48;
            this.la.Text = "Medicine Validity Check";
            // 
            // dgvValidityCheck
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvValidityCheck.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvValidityCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvValidityCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvValidityCheck.ColumnHeadersHeight = 21;
            this.dgvValidityCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvValidityCheck.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvValidityCheck.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvValidityCheck.Location = new System.Drawing.Point(36, 277);
            this.dgvValidityCheck.Name = "dgvValidityCheck";
            this.dgvValidityCheck.RowHeadersVisible = false;
            this.dgvValidityCheck.Size = new System.Drawing.Size(934, 319);
            this.dgvValidityCheck.TabIndex = 49;
            this.dgvValidityCheck.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvValidityCheck.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvValidityCheck.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvValidityCheck.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvValidityCheck.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvValidityCheck.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvValidityCheck.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvValidityCheck.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvValidityCheck.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvValidityCheck.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvValidityCheck.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvValidityCheck.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvValidityCheck.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvValidityCheck.ThemeStyle.ReadOnly = false;
            this.dgvValidityCheck.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvValidityCheck.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvValidityCheck.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvValidityCheck.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvValidityCheck.ThemeStyle.RowsStyle.Height = 22;
            this.dgvValidityCheck.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvValidityCheck.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Check";
            // 
            // cmbCheck
            // 
            this.cmbCheck.BackColor = System.Drawing.Color.Transparent;
            this.cmbCheck.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheck.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCheck.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCheck.ForeColor = System.Drawing.Color.Black;
            this.cmbCheck.ItemHeight = 30;
            this.cmbCheck.Items.AddRange(new object[] {
            "Valid Medicines",
            "Expired Medicines",
            "View All Medicines"});
            this.cmbCheck.Location = new System.Drawing.Point(393, 154);
            this.cmbCheck.Name = "cmbCheck";
            this.cmbCheck.Size = new System.Drawing.Size(399, 36);
            this.cmbCheck.TabIndex = 51;
            this.cmbCheck.SelectedIndexChanged += new System.EventHandler(this.cmbCheck_SelectedIndexChanged);
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.Location = new System.Drawing.Point(35, 254);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(37, 20);
            this.lblSet.TabIndex = 52;
            this.lblSet.Text = "Set";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Uc_P_ValidityCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSet);
            this.Controls.Add(this.cmbCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvValidityCheck);
            this.Controls.Add(this.la);
            this.Name = "Uc_P_ValidityCheck";
            this.Size = new System.Drawing.Size(1053, 634);
            this.Load += new System.EventHandler(this.Uc_P_ValidityCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidityCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la;
        private Guna.UI2.WinForms.Guna2DataGridView dgvValidityCheck;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCheck;
        private System.Windows.Forms.Label lblSet;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
