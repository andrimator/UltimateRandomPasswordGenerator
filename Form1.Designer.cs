
namespace RndPassGenForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.genPassword = new System.Windows.Forms.TextBox();
            this.cbxLetters = new System.Windows.Forms.CheckBox();
            this.cbxNumbers = new System.Windows.Forms.CheckBox();
            this.cbxSymbols = new System.Windows.Forms.CheckBox();
            this.cbxMayus = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolstripSaveas = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            resources.ApplyResources(this.btnGenerate, "btnGenerate");
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // genPassword
            // 
            resources.ApplyResources(this.genPassword, "genPassword");
            this.genPassword.Name = "genPassword";
            this.genPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbxLetters
            // 
            resources.ApplyResources(this.cbxLetters, "cbxLetters");
            this.cbxLetters.Checked = true;
            this.cbxLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxLetters.Name = "cbxLetters";
            this.cbxLetters.UseVisualStyleBackColor = true;
            this.cbxLetters.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbxNumbers
            // 
            resources.ApplyResources(this.cbxNumbers, "cbxNumbers");
            this.cbxNumbers.Name = "cbxNumbers";
            this.cbxNumbers.UseVisualStyleBackColor = true;
            this.cbxNumbers.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbxSymbols
            // 
            resources.ApplyResources(this.cbxSymbols, "cbxSymbols");
            this.cbxSymbols.Name = "cbxSymbols";
            this.cbxSymbols.UseVisualStyleBackColor = true;
            this.cbxSymbols.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbxMayus
            // 
            resources.ApplyResources(this.cbxMayus, "cbxMayus");
            this.cbxMayus.Name = "cbxMayus";
            this.cbxMayus.UseVisualStyleBackColor = true;
            this.cbxMayus.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripSaveas});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            // 
            // toolstripSaveas
            // 
            this.toolstripSaveas.Name = "toolstripSaveas";
            resources.ApplyResources(this.toolstripSaveas, "toolstripSaveas");
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8"),
            resources.GetString("comboBox1.Items9"),
            resources.GetString("comboBox1.Items10"),
            resources.GetString("comboBox1.Items11"),
            resources.GetString("comboBox1.Items12"),
            resources.GetString("comboBox1.Items13")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbxMayus);
            this.Controls.Add(this.cbxSymbols);
            this.Controls.Add(this.cbxNumbers);
            this.Controls.Add(this.cbxLetters);
            this.Controls.Add(this.genPassword);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox cbxLetters;
        private System.Windows.Forms.CheckBox cbxNumbers;
        private System.Windows.Forms.CheckBox cbxSymbols;
        private System.Windows.Forms.CheckBox cbxMayus;
        private System.Windows.Forms.TextBox genPassword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolstripSaveas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
    }
}

