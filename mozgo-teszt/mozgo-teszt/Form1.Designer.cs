namespace mozgo_teszt
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
            this.components = new System.ComponentModel.Container();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iranyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taszimozgasDataSet = new mozgo_teszt.taszimozgasDataSet();
            this.iranyTableAdapter = new mozgo_teszt.taszimozgasDataSetTableAdapters.iranyTableAdapter();
            this.tableAdapterManager = new mozgo_teszt.taszimozgasDataSetTableAdapters.TableAdapterManager();
            this.iskolaTableAdapter = new mozgo_teszt.taszimozgasDataSetTableAdapters.iskolaTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iranyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taszimozgasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1108, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // iranyBindingSource
            // 
            this.iranyBindingSource.DataMember = "irany";
            this.iranyBindingSource.DataSource = this.taszimozgasDataSet;
            this.iranyBindingSource.CurrentChanged += new System.EventHandler(this.iranyBindingSource_CurrentChanged);
            // 
            // taszimozgasDataSet
            // 
            this.taszimozgasDataSet.DataSetName = "taszimozgasDataSet";
            this.taszimozgasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iranyTableAdapter
            // 
            this.iranyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.eszkozTableAdapter = null;
            this.tableAdapterManager.felelosTableAdapter = null;
            this.tableAdapterManager.iranyTableAdapter = this.iranyTableAdapter;
            this.tableAdapterManager.iskolaTableAdapter = null;
            this.tableAdapterManager.megnevezesTableAdapter = null;
            this.tableAdapterManager.mozgasTableAdapter = null;
            this.tableAdapterManager.oprendszerTableAdapter = null;
            this.tableAdapterManager.tarhelyTableAdapter = null;
            this.tableAdapterManager.technologiaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = mozgo_teszt.taszimozgasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iskolaTableAdapter
            // 
            this.iskolaTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iranyBindingSource, "Nev", true));
            this.textBox1.Location = new System.Drawing.Point(78, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.iranyBindingSource, "Nev", true));
            this.textBox2.Location = new System.Drawing.Point(78, 254);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.iranyBindingSource, "Nev", true));
            this.textBox3.Location = new System.Drawing.Point(78, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iranyBindingSource, "Id", true));
            this.textBox4.Location = new System.Drawing.Point(78, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 631);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fillByToolStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iranyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taszimozgasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private taszimozgasDataSet taszimozgasDataSet;
        private System.Windows.Forms.BindingSource iranyBindingSource;
        private taszimozgasDataSetTableAdapters.iranyTableAdapter iranyTableAdapter;
        private taszimozgasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private taszimozgasDataSetTableAdapters.iskolaTableAdapter iskolaTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
    }
}

