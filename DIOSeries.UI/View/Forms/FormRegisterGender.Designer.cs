
namespace DIOSeries.UI {
    partial class FormCategorias {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddGender = new System.Windows.Forms.Button();
            this.textBoxTotalGender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.radioButtonFilterActive = new System.Windows.Forms.RadioButton();
            this.radioButtonFilterDeleted = new System.Windows.Forms.RadioButton();
            this.radioButtonFilterAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(26, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 1);
            this.panel1.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(30, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 26);
            this.label6.TabIndex = 57;
            this.label6.Text = "Esse é um projeto que desenvolvi como parte dos desefios da plataforma DIO\r\ne do " +
    "Bootcamp da Averes relacionados a plataforma .NET com C#\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.dataGridView1.Location = new System.Drawing.Point(33, 128);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(398, 188);
            this.dataGridView1.TabIndex = 71;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarCategoriaToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 64);
            // 
            // deletarCategoriaToolStripMenuItem
            // 
            this.deletarCategoriaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.deletarCategoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletarCategoriaToolStripMenuItem.Image")));
            this.deletarCategoriaToolStripMenuItem.Name = "deletarCategoriaToolStripMenuItem";
            this.deletarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.deletarCategoriaToolStripMenuItem.Text = "Deletar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.editarToolStripMenuItem.Text = "Renomear";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(112, 390);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 24);
            this.textBox1.TabIndex = 73;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 68);
            this.panel2.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 29);
            this.label5.TabIndex = 67;
            this.label5.Text = "Minhas Categorias";
            // 
            // buttonAddGender
            // 
            this.buttonAddGender.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddGender.FlatAppearance.BorderSize = 0;
            this.buttonAddGender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddGender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGender.ForeColor = System.Drawing.Color.White;
            this.buttonAddGender.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddGender.Image")));
            this.buttonAddGender.Location = new System.Drawing.Point(404, 384);
            this.buttonAddGender.Name = "buttonAddGender";
            this.buttonAddGender.Size = new System.Drawing.Size(31, 33);
            this.buttonAddGender.TabIndex = 68;
            this.buttonAddGender.UseVisualStyleBackColor = false;
            // 
            // textBoxTotalGender
            // 
            this.textBoxTotalGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.textBoxTotalGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalGender.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxTotalGender.Location = new System.Drawing.Point(387, 322);
            this.textBoxTotalGender.Name = "textBoxTotalGender";
            this.textBoxTotalGender.ReadOnly = true;
            this.textBoxTotalGender.Size = new System.Drawing.Size(44, 15);
            this.textBoxTotalGender.TabIndex = 74;
            this.textBoxTotalGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(283, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Total de categorias";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.LightSteelBlue;
            this.linkLabel3.Location = new System.Drawing.Point(360, 435);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(75, 13);
            this.linkLabel3.TabIndex = 83;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Carlos Antonio";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(266, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Desenvolvido por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Nova categoria:";
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelInformation.ForeColor = System.Drawing.Color.Red;
            this.labelInformation.Location = new System.Drawing.Point(23, 447);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(0, 13);
            this.labelInformation.TabIndex = 85;
            // 
            // radioButtonFilterActive
            // 
            this.radioButtonFilterActive.AutoSize = true;
            this.radioButtonFilterActive.Checked = true;
            this.radioButtonFilterActive.ForeColor = System.Drawing.Color.Gray;
            this.radioButtonFilterActive.Location = new System.Drawing.Point(126, 351);
            this.radioButtonFilterActive.Name = "radioButtonFilterActive";
            this.radioButtonFilterActive.Size = new System.Drawing.Size(92, 17);
            this.radioButtonFilterActive.TabIndex = 88;
            this.radioButtonFilterActive.TabStop = true;
            this.radioButtonFilterActive.Text = "Mostrar Ativas";
            this.radioButtonFilterActive.UseVisualStyleBackColor = true;
            // 
            // radioButtonFilterDeleted
            // 
            this.radioButtonFilterDeleted.AutoSize = true;
            this.radioButtonFilterDeleted.ForeColor = System.Drawing.Color.Gray;
            this.radioButtonFilterDeleted.Location = new System.Drawing.Point(224, 351);
            this.radioButtonFilterDeleted.Name = "radioButtonFilterDeleted";
            this.radioButtonFilterDeleted.Size = new System.Drawing.Size(110, 17);
            this.radioButtonFilterDeleted.TabIndex = 87;
            this.radioButtonFilterDeleted.Text = "Mostrar Excluídas";
            this.radioButtonFilterDeleted.UseVisualStyleBackColor = true;
            // 
            // radioButtonFilterAll
            // 
            this.radioButtonFilterAll.AutoSize = true;
            this.radioButtonFilterAll.ForeColor = System.Drawing.Color.Gray;
            this.radioButtonFilterAll.Location = new System.Drawing.Point(36, 351);
            this.radioButtonFilterAll.Name = "radioButtonFilterAll";
            this.radioButtonFilterAll.Size = new System.Drawing.Size(84, 17);
            this.radioButtonFilterAll.TabIndex = 86;
            this.radioButtonFilterAll.Text = "Mostrar tudo";
            this.radioButtonFilterAll.UseVisualStyleBackColor = true;
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(462, 473);
            this.Controls.Add(this.radioButtonFilterActive);
            this.Controls.Add(this.radioButtonFilterDeleted);
            this.Controls.Add(this.radioButtonFilterAll);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddGender);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotalGender);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletarCategoriaToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAddGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTotalGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.RadioButton radioButtonFilterActive;
        private System.Windows.Forms.RadioButton radioButtonFilterDeleted;
        private System.Windows.Forms.RadioButton radioButtonFilterAll;
    }
}