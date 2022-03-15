namespace DTH175190_TheCoffeHouse.General
{
    partial class fMess_YESNO
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
            this.lbShow = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContaint = new System.Windows.Forms.Panel();
            this.btnNO = new System.Windows.Forms.Button();
            this.btnYES = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlContaint.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbShow
            // 
            this.lbShow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbShow.Location = new System.Drawing.Point(7, 29);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(291, 54);
            this.lbShow.TabIndex = 0;
            this.lbShow.Text = "Nội dung thông báo";
            this.lbShow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = global::DTH175190_TheCoffeHouse.Properties.Resources.title;
            this.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(306, 23);
            this.pnlTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHÚ Ý";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // pnlContaint
            // 
            this.pnlContaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlContaint.BackgroundImage = global::DTH175190_TheCoffeHouse.Properties.Resources.title_main2;
            this.pnlContaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContaint.Controls.Add(this.btnNO);
            this.pnlContaint.Controls.Add(this.btnYES);
            this.pnlContaint.Controls.Add(this.lbShow);
            this.pnlContaint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContaint.Location = new System.Drawing.Point(0, 24);
            this.pnlContaint.Name = "pnlContaint";
            this.pnlContaint.Size = new System.Drawing.Size(306, 134);
            this.pnlContaint.TabIndex = 3;
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(193)))), ((int)(((byte)(38)))));
            this.btnNO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNO.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNO.FlatAppearance.BorderSize = 0;
            this.btnNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNO.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNO.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNO.Location = new System.Drawing.Point(175, 98);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(75, 25);
            this.btnNO.TabIndex = 1;
            this.btnNO.Text = "NO";
            this.btnNO.UseVisualStyleBackColor = false;
            // 
            // btnYES
            // 
            this.btnYES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(193)))), ((int)(((byte)(38)))));
            this.btnYES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYES.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYES.FlatAppearance.BorderSize = 0;
            this.btnYES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYES.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYES.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYES.Location = new System.Drawing.Point(62, 98);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(75, 25);
            this.btnYES.TabIndex = 0;
            this.btnYES.Text = "YES";
            this.btnYES.UseVisualStyleBackColor = false;
            // 
            // fMess_YESNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 158);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlContaint);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fMess_YESNO";
            this.Opacity = 0.92D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fMess_YESNO";
            this.TopMost = true;
            this.pnlTitle.ResumeLayout(false);
            this.pnlContaint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbShow;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContaint;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Button btnYES;
    }
}