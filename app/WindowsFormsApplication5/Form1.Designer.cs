namespace WindowsFormsApplication5
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
            this.mANAGERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApplication5.DataSet1();
            this.tRANSPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mANAGERTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.MANAGERTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication5.DataSet1TableAdapters.TableAdapterManager();
            this.tRANSPORTTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.TRANSPORTTableAdapter();
            this.aCCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.ACCOUNTTableAdapter();
            this.bOOKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKINGTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.BOOKINGTableAdapter();
            this.cOUNTRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOUNTRYTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.COUNTRYTableAdapter();
            this.cITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cITYTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.CITYTableAdapter();
            this.hOTELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTELTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.HOTELTableAdapter();
            this.tOUR_VUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOUR_VUTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.TOUR_VUTableAdapter();
            this.aCCOUNT_VUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNT_VUTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.ACCOUNT_VUTableAdapter();
            this.bOOKING_VUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKING_VUTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.BOOKING_VUTableAdapter();
            this.mANAGER_VUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mANAGER_VUTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.MANAGER_VUTableAdapter();
            this.cUST_VUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUST_VUTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.CUST_VUTableAdapter();
            this.hOTEL_VUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTEL_VUTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.HOTEL_VUTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mANAGERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOUR_VUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNT_VUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKING_VUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANAGER_VUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUST_VUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTEL_VUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mANAGERBindingSource
            // 
            this.mANAGERBindingSource.DataMember = "MANAGER";
            this.mANAGERBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRANSPORTBindingSource
            // 
            this.tRANSPORTBindingSource.DataMember = "TRANSPORT";
            this.tRANSPORTBindingSource.DataSource = this.dataSet1;
            // 
            // mANAGERTableAdapter
            // 
            this.mANAGERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCOUNTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKINGTableAdapter = null;
            this.tableAdapterManager.CITYTableAdapter = null;
            this.tableAdapterManager.COUNTRYTableAdapter = null;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.HOTELTableAdapter = null;
            this.tableAdapterManager.MANAGERTableAdapter = this.mANAGERTableAdapter;
            this.tableAdapterManager.TOUR_MANAGERTableAdapter = null;
            this.tableAdapterManager.TOUR_TYPETableAdapter = null;
            this.tableAdapterManager.TOURTableAdapter = null;
            this.tableAdapterManager.TRANSPORTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication5.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tRANSPORTTableAdapter
            // 
            this.tRANSPORTTableAdapter.ClearBeforeFill = true;
            // 
            // aCCOUNTBindingSource
            // 
            this.aCCOUNTBindingSource.DataMember = "ACCOUNT";
            this.aCCOUNTBindingSource.DataSource = this.dataSet1;
            // 
            // aCCOUNTTableAdapter
            // 
            this.aCCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKINGBindingSource
            // 
            this.bOOKINGBindingSource.DataMember = "BOOKING";
            this.bOOKINGBindingSource.DataSource = this.dataSet1;
            // 
            // bOOKINGTableAdapter
            // 
            this.bOOKINGTableAdapter.ClearBeforeFill = true;
            // 
            // cOUNTRYBindingSource
            // 
            this.cOUNTRYBindingSource.DataMember = "COUNTRY";
            this.cOUNTRYBindingSource.DataSource = this.dataSet1;
            // 
            // cOUNTRYTableAdapter
            // 
            this.cOUNTRYTableAdapter.ClearBeforeFill = true;
            // 
            // cITYBindingSource
            // 
            this.cITYBindingSource.DataMember = "CITY";
            this.cITYBindingSource.DataSource = this.dataSet1;
            // 
            // cITYTableAdapter
            // 
            this.cITYTableAdapter.ClearBeforeFill = true;
            // 
            // hOTELBindingSource
            // 
            this.hOTELBindingSource.DataMember = "HOTEL";
            this.hOTELBindingSource.DataSource = this.dataSet1;
            // 
            // hOTELTableAdapter
            // 
            this.hOTELTableAdapter.ClearBeforeFill = true;
            // 
            // tOUR_VUBindingSource
            // 
            this.tOUR_VUBindingSource.DataMember = "TOUR_VU";
            this.tOUR_VUBindingSource.DataSource = this.dataSet1;
            // 
            // tOUR_VUTableAdapter
            // 
            this.tOUR_VUTableAdapter.ClearBeforeFill = true;
            // 
            // aCCOUNT_VUBindingSource
            // 
            this.aCCOUNT_VUBindingSource.DataMember = "ACCOUNT_VU";
            this.aCCOUNT_VUBindingSource.DataSource = this.dataSet1;
            // 
            // aCCOUNT_VUTableAdapter
            // 
            this.aCCOUNT_VUTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKING_VUBindingSource
            // 
            this.bOOKING_VUBindingSource.DataMember = "BOOKING_VU";
            this.bOOKING_VUBindingSource.DataSource = this.dataSet1;
            // 
            // bOOKING_VUTableAdapter
            // 
            this.bOOKING_VUTableAdapter.ClearBeforeFill = true;
            // 
            // mANAGER_VUBindingSource
            // 
            this.mANAGER_VUBindingSource.DataMember = "MANAGER_VU";
            this.mANAGER_VUBindingSource.DataSource = this.dataSet1;
            // 
            // mANAGER_VUTableAdapter
            // 
            this.mANAGER_VUTableAdapter.ClearBeforeFill = true;
            // 
            // cUST_VUBindingSource
            // 
            this.cUST_VUBindingSource.DataMember = "CUST_VU";
            this.cUST_VUBindingSource.DataSource = this.dataSet1;
            // 
            // cUST_VUTableAdapter
            // 
            this.cUST_VUTableAdapter.ClearBeforeFill = true;
            // 
            // hOTEL_VUBindingSource
            // 
            this.hOTEL_VUBindingSource.DataMember = "HOTEL_VU";
            this.hOTEL_VUBindingSource.DataSource = this.dataSet1;
            // 
            // hOTEL_VUTableAdapter
            // 
            this.hOTEL_VUTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(274, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "МЕНЮ\r\n";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(219, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(219, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(219, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(219, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(252, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 462);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mANAGERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOUR_VUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNT_VUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKING_VUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANAGER_VUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUST_VUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTEL_VUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mANAGERBindingSource;
        private DataSet1TableAdapters.MANAGERTableAdapter mANAGERTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tRANSPORTBindingSource;
        private DataSet1TableAdapters.TRANSPORTTableAdapter tRANSPORTTableAdapter;
        private System.Windows.Forms.BindingSource aCCOUNTBindingSource;
        private DataSet1TableAdapters.ACCOUNTTableAdapter aCCOUNTTableAdapter;
        private System.Windows.Forms.BindingSource bOOKINGBindingSource;
        private DataSet1TableAdapters.BOOKINGTableAdapter bOOKINGTableAdapter;
        private System.Windows.Forms.BindingSource cOUNTRYBindingSource;
        private DataSet1TableAdapters.COUNTRYTableAdapter cOUNTRYTableAdapter;
        private System.Windows.Forms.BindingSource cITYBindingSource;
        private DataSet1TableAdapters.CITYTableAdapter cITYTableAdapter;
        private System.Windows.Forms.BindingSource hOTELBindingSource;
        private DataSet1TableAdapters.HOTELTableAdapter hOTELTableAdapter;
        private System.Windows.Forms.BindingSource tOUR_VUBindingSource;
        private DataSet1TableAdapters.TOUR_VUTableAdapter tOUR_VUTableAdapter;
        private System.Windows.Forms.BindingSource aCCOUNT_VUBindingSource;
        private DataSet1TableAdapters.ACCOUNT_VUTableAdapter aCCOUNT_VUTableAdapter;
        private System.Windows.Forms.BindingSource bOOKING_VUBindingSource;
        private DataSet1TableAdapters.BOOKING_VUTableAdapter bOOKING_VUTableAdapter;
        private System.Windows.Forms.BindingSource mANAGER_VUBindingSource;
        private DataSet1TableAdapters.MANAGER_VUTableAdapter mANAGER_VUTableAdapter;
        private System.Windows.Forms.BindingSource cUST_VUBindingSource;
        private DataSet1TableAdapters.CUST_VUTableAdapter cUST_VUTableAdapter;
        private System.Windows.Forms.BindingSource hOTEL_VUBindingSource;
        private DataSet1TableAdapters.HOTEL_VUTableAdapter hOTEL_VUTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

