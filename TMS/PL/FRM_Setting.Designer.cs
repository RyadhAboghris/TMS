namespace TMS.PL
{
    partial class FRM_Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.edt_getNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_updatenote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edt_dataupdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "تلقي الاشعارات";
            // 
            // edt_getNote
            // 
            this.edt_getNote.Location = new System.Drawing.Point(129, 222);
            this.edt_getNote.Name = "edt_getNote";
            this.edt_getNote.Size = new System.Drawing.Size(289, 37);
            this.edt_getNote.TabIndex = 1;
            this.edt_getNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "دقائق";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "دقائق";
            // 
            // edt_updatenote
            // 
            this.edt_updatenote.Location = new System.Drawing.Point(129, 279);
            this.edt_updatenote.Name = "edt_updatenote";
            this.edt_updatenote.Size = new System.Drawing.Size(289, 37);
            this.edt_updatenote.TabIndex = 4;
            this.edt_updatenote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "تحديث الاشعارات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "دقائق";
            // 
            // edt_dataupdate
            // 
            this.edt_dataupdate.Location = new System.Drawing.Point(129, 342);
            this.edt_dataupdate.Name = "edt_dataupdate";
            this.edt_dataupdate.Size = new System.Drawing.Size(289, 37);
            this.edt_dataupdate.TabIndex = 7;
            this.edt_dataupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "تحديث البيانات";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edt_dataupdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edt_updatenote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_getNote);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Setting";
            this.Padding = new System.Windows.Forms.Padding(21);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اعدادات البرنامج";
            this.Load += new System.EventHandler(this.FRM_Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edt_getNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edt_updatenote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edt_dataupdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}
