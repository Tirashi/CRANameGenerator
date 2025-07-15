
namespace CRANameGeneratorUI
{
    partial class FmHome
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
            this.tableLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.dataGridViewBusiness = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxBusinessType = new System.Windows.Forms.ComboBox();
            this.buttonBusinessAdd = new System.Windows.Forms.Button();
            this.labelBusinessCode = new System.Windows.Forms.Label();
            this.labelBusinessProjectName = new System.Windows.Forms.Label();
            this.labelBusinessClientName = new System.Windows.Forms.Label();
            this.labelBusinessType = new System.Windows.Forms.Label();
            this.textBoxBusinessCode = new System.Windows.Forms.TextBox();
            this.textBoxBusinessProjectName = new System.Windows.Forms.TextBox();
            this.textBoxBusinessClientName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelPrincipal.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusiness)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPrincipal
            // 
            this.tableLayoutPanelPrincipal.ColumnCount = 2;
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.51852F));
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.48148F));
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelUserInfo, 0, 0);
            this.tableLayoutPanelPrincipal.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            this.tableLayoutPanelPrincipal.RowCount = 1;
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPrincipal.Size = new System.Drawing.Size(1026, 561);
            this.tableLayoutPanelPrincipal.TabIndex = 0;
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.dataGridViewBusiness);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserInfo.Location = new System.Drawing.Point(3, 3);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(697, 555);
            this.panelUserInfo.TabIndex = 0;
            // 
            // dataGridViewBusiness
            // 
            this.dataGridViewBusiness.AllowUserToAddRows = false;
            this.dataGridViewBusiness.AllowUserToDeleteRows = false;
            this.dataGridViewBusiness.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBusiness.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBusiness.Name = "dataGridViewBusiness";
            this.dataGridViewBusiness.RowTemplate.Height = 25;
            this.dataGridViewBusiness.Size = new System.Drawing.Size(697, 555);
            this.dataGridViewBusiness.TabIndex = 0;
            this.dataGridViewBusiness.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBusiness_CellClick);
            this.dataGridViewBusiness.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewBusiness_CellPainting);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxBusinessType);
            this.panel1.Controls.Add(this.buttonBusinessAdd);
            this.panel1.Controls.Add(this.labelBusinessCode);
            this.panel1.Controls.Add(this.labelBusinessProjectName);
            this.panel1.Controls.Add(this.labelBusinessClientName);
            this.panel1.Controls.Add(this.labelBusinessType);
            this.panel1.Controls.Add(this.textBoxBusinessCode);
            this.panel1.Controls.Add(this.textBoxBusinessProjectName);
            this.panel1.Controls.Add(this.textBoxBusinessClientName);
            this.panel1.Location = new System.Drawing.Point(706, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 233);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxBusinessType
            // 
            this.comboBoxBusinessType.FormattingEnabled = true;
            this.comboBoxBusinessType.Items.AddRange(new object[] {
            "CRA",
            "CRI"});
            this.comboBoxBusinessType.Location = new System.Drawing.Point(154, 49);
            this.comboBoxBusinessType.Name = "comboBoxBusinessType";
            this.comboBoxBusinessType.Size = new System.Drawing.Size(150, 23);
            this.comboBoxBusinessType.TabIndex = 9;
            this.comboBoxBusinessType.Text = "CRA";
            // 
            // buttonBusinessAdd
            // 
            this.buttonBusinessAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBusinessAdd.Location = new System.Drawing.Point(229, 199);
            this.buttonBusinessAdd.Name = "buttonBusinessAdd";
            this.buttonBusinessAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonBusinessAdd.TabIndex = 8;
            this.buttonBusinessAdd.Text = "Ajouter";
            this.buttonBusinessAdd.UseVisualStyleBackColor = true;
            this.buttonBusinessAdd.Click += new System.EventHandler(this.buttonBusinessAdd_Click);
            // 
            // labelBusinessCode
            // 
            this.labelBusinessCode.AutoSize = true;
            this.labelBusinessCode.Location = new System.Drawing.Point(39, 139);
            this.labelBusinessCode.Name = "labelBusinessCode";
            this.labelBusinessCode.Size = new System.Drawing.Size(71, 15);
            this.labelBusinessCode.TabIndex = 7;
            this.labelBusinessCode.Text = "Code affaire";
            // 
            // labelBusinessProjectName
            // 
            this.labelBusinessProjectName.AutoSize = true;
            this.labelBusinessProjectName.Location = new System.Drawing.Point(18, 110);
            this.labelBusinessProjectName.Name = "labelBusinessProjectName";
            this.labelBusinessProjectName.Size = new System.Drawing.Size(85, 15);
            this.labelBusinessProjectName.TabIndex = 6;
            this.labelBusinessProjectName.Text = "Nom du projet";
            // 
            // labelBusinessClientName
            // 
            this.labelBusinessClientName.AutoSize = true;
            this.labelBusinessClientName.Location = new System.Drawing.Point(27, 81);
            this.labelBusinessClientName.Name = "labelBusinessClientName";
            this.labelBusinessClientName.Size = new System.Drawing.Size(83, 15);
            this.labelBusinessClientName.TabIndex = 5;
            this.labelBusinessClientName.Text = "Nom du client";
            // 
            // labelBusinessType
            // 
            this.labelBusinessType.AutoSize = true;
            this.labelBusinessType.Location = new System.Drawing.Point(57, 52);
            this.labelBusinessType.Name = "labelBusinessType";
            this.labelBusinessType.Size = new System.Drawing.Size(53, 15);
            this.labelBusinessType.TabIndex = 4;
            this.labelBusinessType.Text = "CRA/CRI";
            // 
            // textBoxBusinessCode
            // 
            this.textBoxBusinessCode.Location = new System.Drawing.Point(154, 136);
            this.textBoxBusinessCode.Name = "textBoxBusinessCode";
            this.textBoxBusinessCode.Size = new System.Drawing.Size(150, 23);
            this.textBoxBusinessCode.TabIndex = 3;
            // 
            // textBoxBusinessProjectName
            // 
            this.textBoxBusinessProjectName.Location = new System.Drawing.Point(154, 107);
            this.textBoxBusinessProjectName.Name = "textBoxBusinessProjectName";
            this.textBoxBusinessProjectName.Size = new System.Drawing.Size(150, 23);
            this.textBoxBusinessProjectName.TabIndex = 2;
            // 
            // textBoxBusinessClientName
            // 
            this.textBoxBusinessClientName.Location = new System.Drawing.Point(154, 78);
            this.textBoxBusinessClientName.Name = "textBoxBusinessClientName";
            this.textBoxBusinessClientName.Size = new System.Drawing.Size(150, 23);
            this.textBoxBusinessClientName.TabIndex = 1;
            // 
            // FmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 561);
            this.Controls.Add(this.tableLayoutPanelPrincipal);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FmHome";
            this.Text = "Home";
            this.tableLayoutPanelPrincipal.ResumeLayout(false);
            this.panelUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusiness)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxBusinessClientName;
        private System.Windows.Forms.TextBox textBoxBusinessCode;
        private System.Windows.Forms.TextBox textBoxBusinessProjectName;
        private System.Windows.Forms.Button buttonBusinessAdd;
        private System.Windows.Forms.Label labelBusinessCode;
        private System.Windows.Forms.Label labelBusinessProjectName;
        private System.Windows.Forms.Label labelBusinessClientName;
        private System.Windows.Forms.Label labelBusinessType;
        private System.Windows.Forms.DataGridView dataGridViewBusiness;
        private System.Windows.Forms.ComboBox comboBoxBusinessType;
    }
}

